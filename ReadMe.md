# StudentGradeRecordingSystem

[TR]

**Öğrenci Not Kayıt Sistemi (ASP.NET Core MVC/Web API)**

---

## 💻 Proje Hakkında

Bu proje, bir eğitim kurumu için geliştirilmiş, öğrenci notlarını kaydetme ve yönetme sistemidir. Uygulama, **ASP.NET Core** teknolojileri ve **Database First** yaklaşımını kullanarak **önceden tanımlanmış bir veritabanı şeması** üzerinden çalışır. **EF Core Migrations** özelliği kullanılmamaktadır, bu nedenle veritabanının manuel olarak oluşturulması gereklidir.

---

## ✨ Temel Özellikler

### Teknik Özellikler

* **ASP.NET Core MVC/Web API**.
* **Entity Framework Core (EF Core)**: Veritabanı işlemleri.
* **Database First Yaklaşımı**: Modeller, var olan veritabanı şemasından iskelenmiştir.
* **ASP.NET Core Identity**: Kullanıcı (Öğrenci/Öğretmen) kimlik yönetimi.
* **Katmanlı mimari**.

### Kullanıcı / Panel Özellikleri

* **Öğretmen Paneli**: Öğrenci ve ders yönetimi, not girişi (CRUD).
* **Öğrenci Paneli**: Kendi notlarını ve ortalamalarını görüntüleme.
* **Yetkilendirme**: Kullanıcı rolüne (Öğrenci/Öğretmen) göre erişim kontrolü.

---

### 🚀 Nasıl Çalıştırılır?

Bu projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyin:

1.  **Gereksinimler:**
    * **[.NET SDK 6.0 veya üzeri](https://dotnet.microsoft.com/download)**
    * **[SQL Server](https://www.microsoft.com/en-us/sql-server)** (veya SQL Server Express)

2.  **Projeyi Klonlama:**
    ```bash
    git clone [https://github.com/abdullahhaktan/StudentGradeRecordingSystem.git](https://github.com/abdullahhaktan/StudentGradeRecordingSystem.git)
    cd StudentGradeRecordingSystem
    ```

3.  **Bağımlılıkları Yükleme:**
    ```bash
    dotnet restore
    ```

4.  **Veritabanı Ayarları:**
    * **`appsettings.json`** dosyasını açın ve `ConnectionStrings` bölümündeki **DefaultConnection** dizesini kendi yerel SQL Server ayarlarınıza göre güncelleyin.
    * *(Not: Bu dizedeki veritabanı adı, manuel olarak oluşturacağınız veritabanı adıyla eşleşmelidir.)*

5.  **Veritabanını Oluşturma (ZORUNLU MANUEL ADIM):**
    * **Migrations** kullanılmadığı için veritabanını manuel olarak oluşturmanız gerekmektedir.
    * Projenin kök dizininde veya bir alt klasörde bulunan **SQL script dosyasını** (`.sql` uzantılı) bulun.
    * Bu scripti kullanarak SQL Server Management Studio (SSMS) veya Azure Data Studio gibi bir araç ile **veritabanı şemasını oluşturun**.

6.  **Projeyi Çalıştırma:**
    ```bash
    dotnet run
    ```

---
---

[EN]

# StudentGradeRecordingSystem

## 💻 About the Project

This project is a student grade recording and management system built with **ASP.NET Core** technologies using a **Database First** approach. It operates on a **predefined database schema**. Since **EF Core Migrations** is not used, the database must be created manually.

---

## ✨ Core Features

### Technical Features

* **ASP.NET Core MVC/Web API**.
* **Entity Framework Core (EF Core)**: Database operations.
* **Database First Approach**: Models are scaffolded from an existing database schema.
* **ASP.NET Core Identity**: User (Student/Teacher) identity management.
* **Layered architecture**.

### User / UI Features

* **Teacher Panel**: Student and course management, grade entry (CRUD).
* **Student Panel**: Viewing personal grades and averages.
* **Authorization**: Access control based on user role.

---

### 🚀 How to Run

Follow these steps to set up and run the project locally:

1.  **Prerequisites:**
    * **[.NET SDK 6.0 or higher](https://dotnet.microsoft.com/download)**
    * **[SQL Server](https://www.microsoft.com/en-us/sql-server)** (or SQL Server Express)

2.  **Cloning the Project:**
    ```bash
    git clone [https://github.com/abdullahhaktan/StudentGradeRecordingSystem.git](https://github.com/abdullahhaktan/StudentGradeRecordingSystem.git)
    cd StudentGradeRecordingSystem
    ```

3.  **Installing Dependencies:**
    ```bash
    dotnet restore
    ```

4.  **Database Configuration:**
    * Open the **`appsettings.json`** file and update the **DefaultConnection** string in the `ConnectionStrings` section to match your local SQL Server settings.
    * *(Note: The database name in this string must match the name of the database you create manually.)*

5.  **Creating the Database (REQUIRED MANUAL STEP):**
    * Since **Migrations** are not used, you must create the database manually.
    * Locate the **SQL script file** (`.sql` extension) within the project's root or a subfolder.
    * Use a tool like SQL Server Management Studio (SSMS) or Azure Data Studio to **execute this script and create the database schema**.

6.  **Running the Project:**
    ```bash
    dotnet run
    ```
