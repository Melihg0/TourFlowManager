# TourFlowManager

TourFlowManager, tur rehberliği ve müşteri yönetimi süreçlerini düzenlemeyi amaçlayan kapsamlı bir sistemdir. Proje, kullanıcı dostu bir yönetici paneli ve güvenli bir kullanıcı doğrulama sistemiyle, yöneticilerin ve diğer kullanıcıların ihtiyaçlarını karşılamak üzere tasarlanmıştır.

## Ozellikler

### Kullanıcı Rolleri ve Yetkilendirme
Kullanıcılar, sistemdeki rollere göre (Admin, TourGuide, Standart Kullanıcı) farklı yetkilere sahiptir.
Admin: Sistem üzerinde tam kontrol sahibi olup kullanıcıları ve turları yönetir.

### Admin Paneli İşlevleri

#### Kullanıcı Yönetimi:
- Kullanıcı ekleme, düzenleme ve silme işlemleri.
- Silinen kullanıcılar, veri kaybını önlemek amacıyla arşivlenir.

#### Tur Yönetimi:
- Turların türlerini, rehberlerini ve detaylarını ekleme, düzenleme ve silme işlemleri.
- Silinen turlar, sistemin geçmiş verilerini korumak amacıyla arşivlenir.

#### Veri Yedekleme ve Export Import işlemleri:
- Veritabanının yedeğini alabilir ve geri yükleyebilirsiniz.
- Tablo verilerini Excel formatında dışa aktarabilir.
- Harici bir Excel tablosunu mevcut bir tabloya ekleyerek veri entegrasyonu sağlayabilirsiniz.

### Denetim ve Veri Doğrulama
- Sistem genelinde kapsamlı veri kontrolü sağlanır:
- E-posta formatı ve benzersizlik kontrolü.
- Rezervasyon tarihleri ve katılımcı sayısı doğrulama.
- Kullanıcı girişlerinde şifre doğrulama ve güvenlik önlemleri 

## Gereksinimler

- Geliştirme Ortamı: Visual Studio
- Programlama Dili: C# (.NET Framework)
- Veritabanı: SQL Server Management Studio (SSMS)

## Kurulum

1. Bu projeyi klonlayın veya indirin.
2. git clone https://github.com/Melihg0/TourFlowManager.git
3. Visual Studio 2022'yi açın ve projeyi yükleyin.
4. SQL Server Management Studio (SSMS) kullanarak veritabanını oluşturun ve gerekli tabloları ekleyin.
6. Projeyi derleyin ve çalıştırın.
