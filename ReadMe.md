# StudentGradeRecordingSystem

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Design Pattern](https://img.shields.io/badge/Architecture-N--Tier%2FLayered-orange.svg)]()
[![GitHub repo size](https://img.shields.io/github/repo-size/abdullahhaktan/StudentGradeRecordingSystem)](https://github.com/abdullahhaktan/StudentGradeRecordingSystem)
[![GitHub Yıldızları](https://img.shields.io/github/stars/abdullahhaktan/StudentGradeRecordingSystem.svg?style=social)](https://github.com/abdullahhaktan/StudentGradeRecordingSystem/stargazers)
[![Lisans](https://img.shields.io/badge/Lisans-MIT-blue.svg)](LICENSE)

[TR]

**Öğrenci Not Kayıt Sistemi (ASP.NET Core MVC/Web API)**

---

## 💻 Proje Hakkında

Bu proje, bir eğitim kurumu için geliştirilmiş, öğrenci notlarını kaydetme ve yönetme sistemidir. Uygulama, **ASP.NET Core** teknolojileri ve **Database First** yaklaşımını kullanarak **önceden tanımlanmış bir veritabanı şeması** üzerinden çalışır. **EF Core Migrations** özelliği kullanılmamaktadır, bu nedenle veritabanının manuel olarak oluşturulması zorunludur.

---

## ✨ Temel Özellikler

### Teknik Özellikler

* Windows form tabanlı yaklaşım
* **Entity Framework **: Veritabanı işlemleri.
* **Database First Yaklaşımı**: Modeller, var olan veritabanı şemasından iskelenmiştir.

### Kullanıcı / Panel Özellikleri

* **Öğretmen Paneli**: Öğrenci ve ders yönetimi, not girişi (CRUD).
* **Öğrenci Paneli**: Kendi notlarını ve ortalamalarını görüntüleme.
* **Yetkilendirme**: Giriş kontrolüne göre erişim kontrolü.

---

### 🚀 Nasıl Çalıştırılır?

Bu projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyin:

1.  **Gereksinimler:**
    * **[.NET Framework]**
    * **[SQL Server](https://www.microsoft.com/en-us/sql-server)** (veya SQL Server Express)
    * 
2.  **Projeyi Klonlama:**
    ```bash
    git clone [https://github.com/abdullahhaktan/StudentGradeRecordingSystem.git](https://github.com/abdullahhaktan/StudentGradeRecordingSystem.git)
    cd StudentGradeRecordingSystem
    ```

3.  **Bağımlılıkları Yükleme: (Gerekirse) **
    ```bash
    dotnet restore
    ```

4.  **Veritabanı Ayarları:**
    * **`appsettings.json`** dosyasını açın ve `ConnectionStrings` bölümündeki **DefaultConnection** dizesini kendi yerel SQL Server ayarlarınıza göre güncelleyin.
    * *(Not: Bu dizedeki veritabanı adı, manuel olarak oluşturacağınız veritabanı adıyla eşleşmelidir.)*

5.  **Veritabanını Oluşturma (ZORUNLU MANUEL ADIM):**
    * **Migrations** kullanılmadığı için veritabanını manuel olarak oluşturmanız gerekmektedir.
    * Lütfen projenin içinde bulunan **SQL script dosyasını** (`.sql` uzantılı) bulun.
    * SQL Server Management Studio (SSMS) gibi bir araç kullanarak bu scripti çalıştırın ve **veritabanı şemasını oluşturun**.

6.  **Projeyi Çalıştırma:**
    ```bash
    dotnet run
    ```

---
---

[EN]

**Student Grade Recording System (ASP.NET Core MVC/Web API)**

---

## 💻 About the Project

This project is a system developed for an educational institution to record and manage student grades. The application operates on a **predefined database schema** using **ASP.NET Core** technologies and the **Database First** approach. **EF Core Migrations** is not used, making the manual creation of the database mandatory.

---

## ✨ Key Features

### Technical Specifications

* Windows Forms-based approach
* **Entity Framework**: Database operations.
* **Database First Approach**: Models are scaffolded from the existing database schema.

### User / Panel Features

* **Teacher Panel**: Student and course management, grade entry (CRUD).
* **Student Panel**: Viewing their own grades and averages.
* **Authorization**: Access control based on login credentials.

---

### 🚀 How to Run?

Follow the steps below to run this project in your local environment:

1.  **Requirements:**
    * **[.NET Framework]**
    * **[SQL Server](https://www.microsoft.com/en-us/sql-server)** (or SQL Server Express)
    *
2.  **Clone the Project:**
    ```bash
    git clone [https://github.com/abdullahhaktan/StudentGradeRecordingSystem.git](https://github.com/abdullahhaktan/StudentGradeRecordingSystem.git)
    cd StudentGradeRecordingSystem
    ```

3.  **Install Dependencies: (If necessary)**
    ```bash
    dotnet restore
    ```

4.  **Database Configuration:**
    * Open the **`appsettings.json`** file and update the `ConnectionStrings` section with your local SQL Server settings.
    * *(Note: The database name in this string must match the name of the database you will create manually.)*

5.  **Create the Database (MANDATORY MANUAL STEP):**
    * Since **Migrations** are not used, you must create the database manually.
    * Please locate the **SQL script file** (with a `.sql` extension) within the project.
    * Run this script using a tool like SQL Server Management Studio (SSMS) to **create the database schema**.

6.  **Run the Project:**
    ```bash
    dotnet run
    ```

---

<img width="448" height="263" alt="Ekran görüntüsü 2025-10-12 162516" src="https://github.com/user-attachments/assets/0280a1a9-8027-48fa-9cc5-45b357dfb9c8" />

    

