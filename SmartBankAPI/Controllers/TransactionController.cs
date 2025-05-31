using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartBankAPI.Models;
using System.Security.Claims;

namespace SmartBankAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TransactionController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("transfer")]
        [Authorize]
        public async Task<IActionResult> Transfer([FromBody] TransferRequest request)
        {
            var senderUsername = User.FindFirstValue(ClaimTypes.Name);
            var sender = await _context.Users.FirstOrDefaultAsync(u => u.Username == senderUsername);
            var receiver = await _context.Users.FirstOrDefaultAsync(u => u.Username == request.ReceiverUsername);

            if (sender == null || receiver == null)
                return NotFound("Sender or receiver not found.");

            if (request.Amount <= 0)
                return BadRequest("Transfer amount must be greater than zero.");

            if (sender.Balance < request.Amount)
                return BadRequest("Insufficient balance.");

            // Update balances
            sender.Balance -= request.Amount;
            receiver.Balance += request.Amount;

            // Create transaction record
            var transaction = new Transaction
            {
                SenderId = sender.Id,
                ReceiverId = receiver.Id,
                Amount = request.Amount,
                Description = request.Description,
                Date = DateTime.UtcNow // 
            };

            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();

            return Ok("Transfer completed.");
        }


        [HttpGet("history")]
        [Authorize]
        public async Task<IActionResult> GetHistory()
        {
            var senderUsername = User.FindFirstValue(ClaimTypes.Name);
            var sender = await _context.Users.FirstOrDefaultAsync(u => u.Username == senderUsername);

            if (sender == null)
                return NotFound("User not found.");

            var transactions = await _context.Transactions
                .Where(t => t.SenderId == sender.Id)
                .OrderByDescending(t => t.Date)
                .ToListAsync();

            return Ok(transactions);
        }


    }

    public class TransferRequest
    {
        public string ReceiverUsername { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
    }
}
