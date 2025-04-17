🔧 PlumberzProject - Tesisatçı CMS & Web Platformu
ASP.NET Core 7.0 ile geliştirilen modern ve yönetilebilir bir tesisatçı web sitesi uygulaması

📌 Proje Özeti
Bu proje, bir tesisat firmasının dijital varlığını yönetmesini sağlayan, kullanıcı dostu ve fonksiyonel bir CMS (İçerik Yönetim Sistemi) sunar. Hem ziyaretçiler için vitrin hem de yöneticiler için içerik kontrol paneli işlevi görür.

🚀 Kullanılan Teknolojiler
⚙️ ASP.NET Core 7.0

🗃️ Entity Framework Core & MSSQL

🧠 Fluent API ile İlişkilendirme

🖼️ Dinamik Görsel Yönetimi

🔐 Claims-Based Authentication

🧩 Öne Çıkan Özellikler
🔐 Kimlik Doğrulama (Authentication)
Kullanıcılar Claims tabanlı sistemle güvenli bir şekilde giriş yapar.

Rol bazlı yetkilendirme yapılabilir.

📝 Kayıt & Giriş İşlemleri
✔️ Register ve Login sayfaları kullanıcı dostu arayüzlerle entegre edilmiştir.

👤 Oturum açıldıktan sonra kullanıcı verileri Claims üzerinden yönetilir.

🛠️ CMS (Yönetim Paneli)
/Admin alanında; About, Service, Team, Testimonial, Topbar, Contact gibi içerikler yönetilir.

Row Order özelliği ile sıralama kontrolü.

Resim yüklemelerinde doğru algoritmalar ile başarılı dosya işleme.

⭐ Testimonial Yıldız Sistemi
Kullanıcılar veya yöneticiler yorumlara yıldız verebilir.

Görsel olarak çekici, puan sistemine dayalı referans modülü.

🧮 Fluent API ile Tablo İlişkilendirme
User tablosu diğer tablolara Fluent API ile bağlandı.

CreatedBy alanları ID yerine doğrudan ad soyad ile eşleştirildi (manuel ve çalışır halde).

🗂️ DTO Katmanı ile Veri Aktarımı
Tüm alanlarda DTO (Data Transfer Object) yapısı kullanıldı.

AdminDtos ile panel tarafı ve client tarafı ayrıştırıldı.

