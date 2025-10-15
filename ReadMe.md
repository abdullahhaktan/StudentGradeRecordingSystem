# StudentGradeRecordingSystem

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-.NET%20Framework-blueviolet.svg)]()
[![GitHub repo size](https://img.shields.io/github/repo-size/abdullahhaktan/StudentGradeRecordingSystem)](https://github.com/abdullahhaktan/StudentGradeRecordingSystem)
[![GitHub Yıldızları](https://img.shields.io/github/stars/abdullahhaktan/StudentGradeRecordingSystem.svg?style=social)](https://github.com/abdullahhaktan/StudentGradeRecordingSystem/stargazers)
[![Lisans](https://img.shields.io/badge/Lisans-MIT-blue.svg)](LICENSE)

[TR]

**Öğrenci Not Kayıt Sistemi (Windows Forms, .NET Framework)**

---

## 💻 Proje Hakkında

Bu proje, bir eğitim kurumu için geliştirilmiş, öğrenci notlarını kaydetme ve yönetme sistemidir. Uygulama, **Windows Forms** tabanlı bir masaüstü uygulama olarak geliştirilmiştir ve **ADO.NET** kullanarak **SQL Server** veritabanına bağlanır. **Entity Framework** veya ASP.NET Core kullanılmamaktadır; bu nedenle veritabanı işlemleri doğrudan SQL sorguları ile yapılır.

---

## ✨ Temel Özellikler

### Teknik Özellikler

* Windows Forms tabanlı kullanıcı arayüzü
* **ADO.NET** ile veritabanı işlemleri
* SQL Server veritabanı kullanımı

### Kullanıcı / Panel Özellikleri

* **Öğretmen Paneli**: Öğrenci ekleme, not güncelleme, başarı/başarısız sayısı görüntüleme.
* **Öğrenci Paneli**: Kendi notlarını, ortalamalarını ve geçme/kalma durumunu görüntüleme.
* **Giriş Kontrolü**: Öğrenci veya öğretmen paneline numara bazlı erişim.

---

### 🚀 Nasıl Çalıştırılır?

Bu projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyin:

1.  **Gereksinimler:**
    * **.NET Framework**
    * **SQL Server** (veya SQL Server Express)

2.  **Projeyi Klonlama:**
    ```bash
    git clone https://github.com/abdullahhaktan/StudentGradeRecordingSystem.git
    cd StudentGradeRecordingSystem
    ```

3.  **Veritabanı Ayarları:**
    * `Form` veya `FrmOgretmenDetay` içindeki **SqlConnection** nesnesinde yer alan bağlantı dizesini kendi SQL Server ayarlarınıza göre güncelleyin:
      ```csharp
      SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbNotKayit;Integrated Security=True;Encrypt=False");
      ```

4.  **Veritabanını Oluşturma (ZORUNLU MANUEL ADIM):**
    * SQL Server Management Studio (SSMS) veya benzeri bir araç kullanarak veritabanı ve tablo (`TBL_DERS`) oluşturun.
    * Tablo alanları:
      - OGRNUMARA (varchar)
      - OGRAD (nvarchar)
      - OGRSOYAD (nvarchar)
      - OGRS1, OGRS2, OGRS3 (int)
      - ORTALAMA (decimal)
      - DURUM (bit)

5.  **Projeyi Çalıştırma:**
    * Visual Studio ile projeyi açın ve `Form1` üzerinden uygulamayı başlatın.

---

[EN]

**Student Grade Recording System (Windows Forms, .NET Framework)**

---

## 💻 About the Project

This project is a desktop application developed for an educational institution to record and manage student grades. The application uses **Windows Forms** for the UI and **ADO.NET** to interact with a **SQL Server** database. **Entity Framework** or ASP.NET Core is not used.

---

## ✨ Key Features

### Technical Specifications

* Windows Forms-based desktop UI
* **ADO.NET** for database operations
* SQL Server database

### User / Panel Features

* **Teacher Panel**: Add students, update grades, view passed/failed counts.
* **Student Panel**: View own grades, averages, and pass/fail status.
* **Login Control**: Access panels based on numeric ID.

---

### 🚀 How to Run?

1.  **Requirements:**
    * **.NET Framework**
    * **SQL Server** (or SQL Server Express)

2.  **Clone the Project:**
    ```bash
    git clone https://github.com/abdullahhaktan/StudentGradeRecordingSystem.git
    cd StudentGradeRecordingSystem
    ```

3.  **Database Configuration:**
    * Update the **SqlConnection** string in the forms to match your local SQL Server setup:
      ```csharp
      SqlConnection conn = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=DbNotKayit;Integrated Security=True;Encrypt=False");
      ```

4.  **Create the Database (MANDATORY MANUAL STEP):**
    * Create the database and `TBL_DERS` table manually in SQL Server.
    * Table columns:
      - OGRNUMARA (varchar)
      - OGRAD (nvarchar)
      - OGRSOYAD (nvarchar)
      - OGRS1, OGRS2, OGRS3 (int)
      - ORTALAMA (decimal)
      - DURUM (bit)

5.  **Run the Project:**
    * Open in Visual Studio and start from `Form1`.

---

<img width="448" height="263" alt="Ekran görüntüsü 2025-10-12 162516" src="https://github.com/user-attachments/assets/0280a1a9-8027-48fa-9cc5-45b357dfb9c8" />

    


