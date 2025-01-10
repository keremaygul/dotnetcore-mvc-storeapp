# Store App - E-Commerce Application

<div align="center">

# 🌐 Dil Seçimi / Language Selection

### [🇹🇷 Türkçe](#tr) | [🇬🇧 English](#en)

</div>

---
![ss3](https://github.com/user-attachments/assets/1bcc0f02-7406-45f0-bc43-fa1b5f184337)
![ss2](https://github.com/user-attachments/assets/f846f3ea-62a1-4582-ae10-bea8d99efc10)
![ss1](https://github.com/user-attachments/assets/a3bb1579-c7fb-43b6-9525-ec53c235e2ff)
---

<a name="en"></a>
# 🛍️ Store App - E-Commerce Application [EN]

## 📋 About The Project
This is a comprehensive e-commerce application developed using modern web technologies. Built on ASP.NET Core MVC architecture, it follows N-Tier Architecture principles and implements secure authentication and authorization using Identity Framework.

## 🏗️ Architecture

### N-Tier Architecture
The project consists of the following layers:

1. **Entities Layer**
   - Models
     - Product (Product information)
     - Category (Category management)
     - Cart (Shopping cart operations)
     - Order (Order management)
     - CartLine (Cart details)
   - DTOs (Data Transfer Objects)
     - ProductDto (Base product DTO)
     - ProductDtoForInsertion
     - ProductDtoForUpdate
     - UserDto and derivatives
     - RegisterDto
     - ResetPasswordDto
   - Request Parameters
     - Pagination and filtering parameters

2. **Services Layer**
   - Manager Classes
     - ProductManager (Product operations)
     - CategoryManager (Category operations)
     - OrderManager (Order operations)
     - AuthManager (Authentication)
     - ServiceManager (Service management)
   - Service Contracts
     - IAuthService (Authentication service)
     - IServiceManager (Service management interface)
     - IProductService (Product service)
     - ICategoryService (Category service)
     - IOrderService (Order service)

3. **Repositories Layer**
   - Repository Pattern implementation
   - Entity Framework Core integration
   - Generic Repository Base class
   - Specialized repositories:
     - ProductRepository
     - CategoryRepository
     - OrderRepository
   - RepositoryContext (DbContext)
     - Entity configurations
     - Fluent API definitions
   - Extensions
     - Repository extensions
     - Service extensions

4. **Presentation Layer**
   - API Controllers
     - ProductsController
       - RESTful API endpoints
       - HTTP methods (GET, POST, PUT, DELETE)
       - Route definitions
   - Dependency Injection configuration
   - API versioning
   - Response/Request formats

5. **StoreApp (Web UI Layer)**
   - Infrastructure
     - TagHelpers (Custom HTML helpers)
     - Mapper (AutoMapper profiles)
     - Extensions (Application extensions)
   - Models
     - LoginModel (Login model)
     - SessionCart (Session cart)
     - Pagination (Pagination)
     - ProductListViewModel (Product list view model)
   - Controllers
     - ProductController (Product operations)
     - CategoryController (Category operations)
     - AccountController (User operations)
     - OrderController (Order management)
     - HomeController (Home page)
   - Areas
     - Admin Area
       - Dashboard
       - Product Management
       - Category Management
       - User Management
       - Role Management
       - Order Tracking
   - Views
     - Shared Layouts
     - Partial Views
     - Component Views
   - wwwroot
     - CSS (Bootstrap and custom styles)
     - JavaScript
     - Images
     - Third-party libraries

## 🔑 Key Features

- 🛒 Shopping Cart Management
  - Add/remove products
  - Update quantities
  - Calculate total price
  - View cart summary

- 📦 Product Management
  - Detailed product listing
  - Category-based filtering
  - Pagination
  - Search functionality
  - Product detail pages
  - RESTful API support

- 👤 User Management
  - Identity Framework integration
  - Role-based authorization
  - User registration and login
  - Profile management

- 📝 Order System
  - Order creation
  - Order history
  - Order status tracking
  - Admin panel order management

## 💻 Technologies and Tools

### Backend
- ASP.NET Core MVC 8.0
- ASP.NET Core Web API
- Entity Framework Core
- Identity Framework
- MSSQL Server
- Repository Pattern
- Dependency Injection
- AutoMapper

### Frontend
- Bootstrap 5
- HTML5
- CSS3
- JavaScript
- jQuery
- Font Awesome
- Responsive Design

### Security
- Identity Framework Authentication
- Role-based Authorization
- Anti-forgery Tokens
- XSS Protection
- Password Hashing
- Secure Cookie Handling
- API Authentication

## 🚀 User Interface Features

- Responsive design (Mobile-first approach)
- Modern and user-friendly interface
- Bootstrap 5 grid system
- Dynamic form validations
- AJAX-based cart operations
- Real-time notifications
- Easy navigation
- Fast page loading

## 👥 User Roles and Permissions

1. **Admin**
   - Full management access
   - Product CRUD operations
   - Category management
   - User management
   - Role assignment/editing
   - Order management
   - System settings

2. **User**
   - Product listing and search
   - Add to cart
   - Create orders
   - View order history
   - Profile management

## 🔒 Security Measures

- Strong password policy
- JWT-based authentication
- Role-based access control (RBAC)
- Cross-Site Request Forgery (CSRF) protection
- SQL Injection protection
- XSS (Cross-Site Scripting) protection
- Secure session management
- API security

## 🌟 Advanced Features

- Dynamic filtering system
- Advanced search functionality
- Pagination and sorting
- Image upload and optimization
- Cart persistence
- Email notifications
- Order tracking system
- RESTful API integration

## 📈 Performance Optimizations

- Entity Framework lazy loading
- Database indexing
- Query optimization
- Caching mechanisms
- Asynchronous programming
- Minimal API usage
- Resource minification
- API response optimization

---

<a name="tr"></a>
# 🛍️ Store App - E-Ticaret Uygulaması [TR]

## 📋 Proje Hakkında
Bu proje, modern web teknolojileri kullanılarak geliştirilmiş kapsamlı bir e-ticaret uygulamasıdır. ASP.NET Core MVC mimarisi üzerine inşa edilmiş olup, çok katmanlı mimari (N-Tier Architecture) prensiplerine uygun olarak tasarlanmıştır. Identity Framework ile güvenli kimlik doğrulama ve yetkilendirme sağlanmıştır.

## 🏗️ Mimari Yapı

### Katmanlı Mimari
Proje, aşağıdaki katmanlardan oluşmaktadır:

1. **Entities Layer**
   - Models
     - Product (Ürün bilgileri)
     - Category (Kategori yönetimi)
     - Cart (Sepet işlemleri)
     - Order (Sipariş yönetimi)
     - CartLine (Sepet detayları)
   - DTOs (Data Transfer Objects)
     - ProductDto (Temel ürün DTO)
     - ProductDtoForInsertion
     - ProductDtoForUpdate
     - UserDto ve türevleri
     - RegisterDto
     - ResetPasswordDto
   - Request Parameters
     - Sayfalama ve filtreleme parametreleri

2. **Services Layer**
   - Manager Sınıfları
     - ProductManager (Ürün işlemleri)
     - CategoryManager (Kategori işlemleri)
     - OrderManager (Sipariş işlemleri)
     - AuthManager (Kimlik doğrulama)
     - ServiceManager (Servis yönetimi)
   - Service Contracts
     - IAuthService (Kimlik doğrulama servisi)
     - IServiceManager (Servis yönetim arayüzü)
     - IProductService (Ürün servisi)
     - ICategoryService (Kategori servisi)
     - IOrderService (Sipariş servisi)

3. **Repositories Layer**
   - Repository Pattern implementasyonu
   - Entity Framework Core entegrasyonu
   - Generic Repository Base sınıfı
   - Özelleştirilmiş repository'ler:
     - ProductRepository
     - CategoryRepository
     - OrderRepository
   - RepositoryContext (DbContext)
     - Entity konfigürasyonları
     - Fluent API tanımlamaları
   - Extensions
     - Repository uzantıları
     - Servis uzantıları

4. **Presentation Layer**
   - API Controllers
     - ProductsController
       - RESTful API endpoints
       - HTTP metodları (GET, POST, PUT, DELETE)
       - Route tanımlamaları
   - Dependency Injection yapılandırması
   - API versiyonlama
   - Response/Request formatları

5. **StoreApp (Web UI Layer)**
   - Infrastructure
     - TagHelpers (Özel HTML helper'lar)
     - Mapper (AutoMapper profilleri)
     - Extensions (Uygulama uzantıları)
   - Models
     - LoginModel (Giriş modeli)
     - SessionCart (Oturum sepeti)
     - Pagination (Sayfalama)
     - ProductListViewModel (Ürün liste görünümü)
   - Controllers
     - ProductController (Ürün işlemleri)
     - CategoryController (Kategori işlemleri)
     - AccountController (Kullanıcı işlemleri)
     - OrderController (Sipariş yönetimi)
     - HomeController (Ana sayfa)
   - Areas
     - Admin Area
       - Dashboard
       - Ürün Yönetimi
       - Kategori Yönetimi
       - Kullanıcı Yönetimi
       - Rol Yönetimi
       - Sipariş Takibi
   - Views
     - Shared Layouts
     - Partial Views
     - Component Views
   - wwwroot
     - CSS (Bootstrap ve özel stiller)
     - JavaScript
     - Resimler
     - Üçüncü parti kütüphaneler

## 🔑 Temel Özellikler

- 🛒 Alışveriş Sepeti Yönetimi
  - Ürün ekleme/çıkarma
  - Miktar güncelleme
  - Toplam fiyat hesaplama
  - Sepet özeti görüntüleme

- 📦 Ürün Yönetimi
  - Detaylı ürün listeleme
  - Kategori bazlı filtreleme
  - Sayfalama
  - Arama fonksiyonu
  - Ürün detay sayfaları
  - RESTful API desteği

- 👤 Kullanıcı Yönetimi
  - Identity Framework entegrasyonu
  - Rol bazlı yetkilendirme
  - Kullanıcı kaydı ve girişi
  - Profil yönetimi

- 📝 Sipariş Sistemi
  - Sipariş oluşturma
  - Sipariş geçmişi
  - Sipariş durumu takibi
  - Admin panelinden sipariş yönetimi

## 💻 Teknolojiler ve Araçlar

### Backend
- ASP.NET Core MVC 8.0
- ASP.NET Core Web API
- Entity Framework Core
- Identity Framework
- MSSQL Server
- Repository Pattern
- Dependency Injection
- AutoMapper

### Frontend
- Bootstrap 5
- HTML5
- CSS3
- JavaScript
- jQuery
- Font Awesome
- Responsive Design

### Güvenlik
- Identity Framework Authentication
- Role-based Authorization
- Anti-forgery Tokens
- XSS Protection
- Password Hashing
- Secure Cookie Handling
- API Authentication

## 🚀 Kullanıcı Arayüzü Özellikleri

- Responsive tasarım (Mobile-first yaklaşım)
- Modern ve kullanıcı dostu arayüz
- Bootstrap 5 grid sistemi
- Dinamik form validasyonları
- AJAX tabanlı sepet işlemleri
- Anlık bildirimler
- Kolay navigasyon
- Hızlı sayfa yüklemeleri

## 👥 Kullanıcı Rolleri ve İzinler

1. **Admin**
   - Tam yönetim yetkisi
   - Ürün CRUD işlemleri
   - Kategori yönetimi
   - Kullanıcı yönetimi
   - Rol atama/düzenleme
   - Sipariş yönetimi
   - Sistem ayarları

2. **Kullanıcı**
   - Ürün listeleme ve arama
   - Sepete ürün ekleme
   - Sipariş oluşturma
   - Sipariş geçmişi görüntüleme
   - Profil yönetimi

## 🔒 Güvenlik Önlemleri

- Güçlü parola politikası
- JWT tabanlı kimlik doğrulama
- Role-based access control (RBAC)
- Cross-Site Request Forgery (CSRF) koruması
- SQL Injection koruması
- XSS (Cross-Site Scripting) koruması
- Güvenli oturum yönetimi
- API güvenliği

## 🌟 Gelişmiş Özellikler

- Dinamik filtreleme sistemi
- Gelişmiş arama fonksiyonu
- Sayfalama ve sıralama
- Resim yükleme ve optimizasyon
- Sepet persistence
- Email bildirimleri
- Sipariş takip sistemi
- RESTful API entegrasyonu

## 📈 Performans Optimizasyonları

- Entity Framework lazy loading
- Veritabanı indeksleme
- Query optimizasyonu
- Caching mekanizmaları
- Asenkron programlama
- Minimal API kullanımı
- Resource minification
- API response optimizasyonu 
