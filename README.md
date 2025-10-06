# 🧱 Rens Blog Server

**Rens Blog**, modern web teknolojileriyle geliştirilen tam kapsamlı bir blog platformudur.  
Bu repo, projenin **backend (sunucu)** kısmını içermektedir.

Frontend tarafında **Angular 20**, backend tarafında ise **.NET 9** kullanılarak geliştirilmektedir.  
Amacımız, **kurumsal düzeyde bir mimariyle**, hem performanslı hem de bakımı kolay bir uygulama inşa etmektir.

---

## 🚀 Bu Projede Sizi Neler Bekliyor?

### 🔧 Backend (.NET 9)

Backend tarafında **kaya gibi sağlam bir temel** üzerine inşa edilmiş bir yapı sizi bekliyor:

#### 🧅 Onion / Clean Architecture
Katmanlı mimari yaklaşımıyla kodunuzu;
- **test edilebilir,**
- **bakımı kolay,**
- **bağımlılıklardan arındırılmış**
hale getiriyoruz.  
Spagetti koda veda edin! 🍝

#### 🧭 Mediator Design Pattern (MediatR)
Uygulama içi iletişimi **komut (Command)** ve **sorgu (Query)** mantığıyla yönetin.  
**MediatR** kütüphanesiyle, controller’larınızın karmaşasını azaltın, kodunuzu sadeleştirin.

#### 🌐 RESTful API Geliştirme
Modern standartlara uygun, güvenli ve hızlı **API endpoint’leri** oluşturuyoruz:
- CRUD operasyonları  
- Global exception handling  
- Validation ve response modelleri  
- Logging ve middleware kullanımı  

#### 🗄️ Entity Framework Core
Veritabanı işlemlerinde profesyonel seviye kontrol:  
Migration’lar, LINQ sorguları, ilişkiler ve performans optimizasyonu.

#### 🔐 JWT Authentication & Authorization
Kullanıcı giriş/çıkış işlemleri, roller ve token yönetimiyle güçlü güvenlik alt yapısı.  
Kullanıcıların sadece yetkili olduğu alanlara erişmesini sağlayın.

---

### 💻 Frontend (Angular 20)

Blog’un görsel ve etkileşimli kısmı **Angular 20** ile geliştiriliyor.

#### 🧩 Modern Angular Mimarisi
Component, Service, Module yapısı ile:
- **Modüler,**
- **Yeniden kullanılabilir,**
- **Bakımı kolay**
bir frontend mimarisi oluşturuyoruz.

#### 📱 Responsive (Duyarlı) Tasarım
Mobil, tablet ve masaüstü cihazlarda mükemmel kullanıcı deneyimi.  
CSS ve modern UI kütüphaneleriyle her çözünürlükte uyumlu arayüz.

#### 🔗 Backend API Entegrasyonu
Oluşturduğumuz .NET API ile tam entegre çalışan bir Angular uygulaması:  
Veri alışverişi, JWT token doğrulama ve async işlem yönetimi.

#### ⚡ Single Page Application (SPA)
Angular Router ile hızlı, kesintisiz ve akıcı kullanıcı deneyimi.  
Sayfa yenilenmeden veri güncellemeleri — tamamen modern web standardı.

---

## 🧠 Proje Mimarisi

```bash
Rens-Blog-Server/
├── RensBlog.API/               # API katmanı (Controller'lar, Middleware, Configurations)
├── RensBlog.Application/       # İş mantığı (CQRS, DTO'lar, Handlers, Interfaces)
├── RensBlog.Domain/            # Entity modelleri, temel domain sınıfları
├── RensBlog.Infrastructure/    # Veri erişimi, EF Core, repository implementasyonları
└── RensBlog.Persistence/       # Context, migrations ve database yapılandırmaları
