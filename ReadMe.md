# StudentGradeRecordingSystem

[TR]

**Öğrenci Not Kayıt Sistemi (ASP.NET Core MVC/Web API)**

---

## 💻 Proje Hakkında

Bu proje, bir eğitim kurumu veya sınıf için geliştirilmiş, **öğrenci notlarını kaydetme ve yönetme** sistemidir. **ASP.NET Core** teknolojileri kullanılarak geliştirilmiş olup, öğrenci bilgilerini, dersleri ve sınav notlarını merkezi bir veritabanında saklamayı ve kullanıcı (öğrenci/öğretmen) bazında erişim sağlamayı amaçlar.

---

## ✨ Temel Özellikler

### Teknik Özellikler

* **Katmanlı mimari** (DataAccess / Business / WebUI/API)
* **Entity Framework Core (EF Core)** ile veritabanı işlemleri
* **ASP.NET Core Identity** ile kullanıcı (Öğrenci/Öğretmen) kimlik yönetimi
* **Code First** yaklaşımıyla veritabanı oluşturma
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

4.  **Veritabanı Ayarları:**
    * `appsettings.json` dosyasını açın ve `ConnectionStrings` bölümündeki veritabanı bağlantı dizesini (`DefaultConnection`) kendi yerel SQL Server ayarlarınıza göre güncelleyin.

5.  **Veritabanını Oluşturma (Migrations):**
    * Projenin kök dizininde komut satırını kullanın:
        ```bash
        dotnet ef database update
        ```

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

This project is a **student grade recording and management system** developed for an educational institution or classroom setting. It is built using **ASP.NET Core** technologies to securely store student information, courses, and exam grades in a central database, while providing role-based access for users (students/teachers).

---

## ✨ Core Features

### Technical Features

* **Layered architecture** (DataAccess / Business / WebUI/API)
* Database operations using **Entity Framework Core (EF Core)**
* User (Student/Teacher) identity management with **ASP.NET Core Identity**
* Database creation using the **Code First** approach
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
    * [SQL Server](https://www.microsoft.com/en-us/sql-server) (or preferred database)
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

4.  **Database Configuration:**
    * Open the `appsettings.json` file and update the database connection string (`DefaultConnection`) under the `ConnectionStrings` section to match your local database settings.

5.  **Creating the Database (Migrations):**
    * Use the command line in the project's root directory:
        ```bash
        dotnet ef database update
        ```

6.  **Running the Project:**
    * Open the project in Visual Studio or run it via the command line:
        ```bash
        dotnet run
        ```
    * The application will typically start running at an address like `https://localhost:[PORT]`.
---
---

<img width="449" height="258" alt="Ekran görüntüsü 2025-10-04 122424" src="https://github.com/user-attachments/assets/f104b175-7566-48e6-9911-f26683280532" />
<img width="863" height="405" alt="Ekran görüntüsü 2025-10-04 122328" src="https://github.com/user-attachments/assets/576f6611-0f97-487f-897a-d1ac80c8ef81" />

