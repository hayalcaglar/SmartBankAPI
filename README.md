# 🧠 SmartBankAPI (.NET Core Web API)

SmartBankAPI is the backend of the fullstack SmartBank project. Built with **ASP.NET Core**, it features secure login, money transfers, and transaction history — all stored with **SQLite** and protected with **JWT authentication**.

---

## ✅ Features

- 🔐 User login with SHA256 + JWT
- 👤 Authenticated API endpoints
- 💰 Balance tracking per user
- 🔁 Money transfers between users
- 📜 Transaction history
- 🛡 Token expiration handling
- 📦 SQLite + Entity Framework Core
- 🧪 Swagger UI for testing endpoints

---

## 🛠 Tech Stack

- ASP.NET Core 8
- Entity Framework Core
- SQLite
- JWT Authentication
- Swashbuckle Swagger

---

## 🚀 Getting Started

1. Open the solution: `SmartBankAPI.sln`
2. Restore NuGet packages
3. Update database with EF Core migrations
4. Run the project
5. Visit Swagger at: `https://localhost:7116/swagger`

💡 This API integrates with the React frontend:  
👉 https://github.com/yourusername/smartbank-frontend

---

## 👨‍💻 Developer

**Hayal Çağlar**  

---

## 🇹🇷 Türkçe Açıklama

**SmartBankAPI**, dijital bankacılığı simüle eden bir ASP.NET Core Web API projesidir. Kullanıcılar giriş yapabilir, bakiye görüntüleyebilir, başka kullanıcılara para gönderebilir ve işlem geçmişini görüntüleyebilir.

### Özellikler:

- 🔐 SHA256 + JWT ile güvenli giriş sistemi
- 💳 Kullanıcı bakiyesi takibi
- 🔁 Kullanıcı adına para transferi
- 📜 İşlem geçmişi listesi
- 🧪 Swagger arayüzü ile test
- 📦 SQLite veritabanı (EF Core ile)

---

## 🧪 Nasıl Çalıştırılır?

1. `SmartBankAPI.sln` dosyasını aç
2. NuGet paketlerini yükle (`Restore`)
3. EF Core ile database migration çalıştır (opsiyonel)
4. Uygulamayı başlat
5. `https://localhost:7116/swagger` adresinden test et

---

## 🎯 Proje Durumu

SmartBankAPI tamamlandı ve frontend ile tam entegre çalışır durumdadır.
