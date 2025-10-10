# StudentGradeRecordingSystem

[TR]

**Öğrenci Not Kayıt Sistemi (ASP.NET Core MVC/Web API)**

---

## 💻 Proje Hakkında

Bu proje, bir eğitim kurumu veya sınıf için geliştirilmiş, **öğrenci notlarını kaydetme ve yönetme** sistemidir. **ASP.NET Core** teknolojileri kullanılarak geliştirilmiş olup, var olan bir veritabanı şemasına bağlanarak öğrenci bilgilerini, dersleri ve sınav notlarını yönetmeyi amaçlar. Proje, özellikle **Database First** yaklaşımını uygulamalı olarak göstermektedir.

---

## ✨ Temel Özellikler

### Teknik Özellikler

* **Katmanlı mimari** (DataAccess / Business / WebUI/API)
* **Entity Framework Core (EF Core)** ile veritabanı işlemleri (Modeller, **Database First** yaklaşımıyla mevcut veritabanından oluşturulmuştur).
* **ASP.NET Core Identity** ile kullanıcı (Öğrenci/Öğretmen) kimlik yönetimi
* **Database First** yaklaşımıyla mevcut veritabanı şeması kullanılır.
* **Repository Pattern** veya **Service Pattern** kullanımı
* Veri transferi ve modelleme için **View Model / DTO** kullanımı

### Kullanıcı / Panel Özellikleri

* **Öğretmen Paneli**:
    * Yeni dersler ve öğrenciler ekleme/silme/güncelleme (CRUD).
    * Öğrencilere ders bazında not girişi ve not güncelleme.
* **Öğrenci Paneli**:
    * Kayıtlı olduğu dersleri listeleme.
    * Kendi sınav notlarını ve ortalamalarını görüntüleme.
* **Sınav ve Not Yönetimi**: Vize, final ve diğer değerlendirme notlarının kaydı.
* **Yetkilendirme**: Kullanıcı rolüne (Öğrenci/Öğretmen) göre arayüze ve verilere erişim kontrolü.

---

### 🚀 Nasıl Çalıştırılır?

Bu projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyin:

1.  **Gereksinimler:**
    * [.NET SDK 6.0 veya üzeri](https://dotnet.microsoft.com/download)
    * [SQL Server](https://www.microsoft.com/en-us/sql-server) (veya SQL Server Express)
    * [Visual Studio 2022](https://visualstudio.microsoft.com/) (Önerilen)

2.  **Projeyi Klonlama:**
    ```bash
    git clone [https://github.com/abdullahhaktan/StudentGradeRecordingSystem.git](https://github.com/abdullahhaktan/StudentGradeRecordingSystem.git)
    cd StudentGradeRecordingSystem
    ```

3.  **Bağımlılıkları Yükleme:**
    ```bash
    dotnet restore
    ```

4.  **Veritabanını Hazırlama (Database First Adımı):**
    * Projenin çalışması için gerekli olan veritabanı şemasını (genellikle bir SQL scripti veya `.bak` dosyası) yerel **SQL Server**'ınızda oluşturun/geri yükleyin.
    * Veritabanı adı ve şemasının, projede beklenen yapıyla (modellerin oluşturulduğu veritabanı) **tam olarak eşleştiğinden** emin olun.

5.  **Veritabanı Ayarları (Connection String):**
    * `appsettings.json` dosyasını açın ve `ConnectionStrings` bölümündeki veritabanı bağlantı dizesini (`DefaultConnection`) **hazırladığınız** yerel SQL Server veritabanı ayarlarınıza göre güncelleyin.

6.  **Projeyi Çalıştırma:**
    * Projeyi Visual Studio'da açın veya komut satırında çalıştırın:
        ```bash
        dotnet run
        ```
    * Uygulama genellikle `https://localhost:[PORT]` (veya benzeri bir adreste) çalışmaya başlayacaktır.

---
---

[EN]

# StudentGradeRecordingSystem

## 💻 About the Project

This project is a **student grade recording and management system** developed for an educational institution. It uses **ASP.NET Core** technologies to connect to an existing database schema, aiming to manage student information, courses, and exam grades. The project specifically demonstrates the **Database First** approach.

---

## ✨ Core Features

### Technical Features

* **Layered architecture** (DataAccess / Business / WebUI/API)
* Database operations using **Entity Framework Core (EF Core)** (Models are scaffolded from an existing database using the **Database First** approach).
* User (Student/Teacher) identity management with **ASP.NET Core Identity**
* Utilizes an existing database schema (**Database First** approach).
* Use of **Repository Pattern** or **Service Pattern**
* **View Model / DTO** usage for data transfer and modeling

### User / UI Features

* **Teacher Panel**:
    * CRUD operations for adding/deleting/updating new courses and students.
    * Grade entry and updates for students on a per-course basis.
* **Student Panel**:
    * Listing of enrolled courses.
    * Viewing their own exam grades and averages.
* **Exam and Grade Management**: Recording of midterms, finals, and other assessment grades.
* **Authorization**: Access control to the interface and data based on user role (Student/Teacher).

---

### 🚀 How to Run

Follow these steps to set up and run the project locally:

1.  **Prerequisites:**
    * [.NET SDK 6.0 or higher](https://dotnet.microsoft.com/download)
    * [SQL Server](https://www.microsoft.com/en-us/sql-server) (or SQL Server Express)
    * [Visual Studio 2022](https://visualstudio.microsoft.com/) (Recommended)

2.  **Cloning the Project:**
    ```bash
    git clone [https://github.com/abdullahhaktan/StudentGradeRecordingSystem.git](https://github.com/abdullahhaktan/StudentGradeRecordingSystem.git)
    cd StudentGradeRecordingSystem
    ```

3.  **Installing Dependencies:**
    ```bash
    dotnet restore
    ```

4.  **Database Preparation (Database First Step):**
    * Restore the database backup (e.g., a SQL script or `.bak` file) required for the project onto your local **SQL Server** instance.
    * Ensure the database name and schema **exactly match** the structure expected by the project (the database from which the models were scaffolded).

5.  **Database Configuration (Connection String):**
    * Open the `appsettings.json` file and update the database connection string (`DefaultConnection`) under the `ConnectionStrings` section to match the settings of your **prepared** local SQL Server database.

6.  **Running the Project:**
    * Open the project in Visual Studio or run it via the command line:
        ```bash
        dotnet run
        ```
    * The application will typically start running at an address like `https://localhost:[PORT]`.
