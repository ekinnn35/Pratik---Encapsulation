# Araba Encapsulation Projesi

Bu proje, "Araba" sınıfı üzerinde **Encapsulation** (kapsülleme) kavramını uygulamak amacıyla hazırlanmıştır. Arabanın "Kapı Sayısı" özelliği üzerinde kapsülleme yapılarak yalnızca geçerli değerlerin atanmasına izin verilmiştir.

## Amaç

Bu projede, **Encapsulation** kavramını uygulayarak aşağıdaki işlemleri gerçekleştirmek hedeflenmiştir:
- Kapsülleme ile belirli kurallar çerçevesinde veri kontrolü sağlamak.
- Nesne tabanlı programlama (OOP) prensiplerini uygulamak.
- Constructor ve Property kullanımı hakkında bilgi edinmek.

## Proje Yapısı

Proje iki ana dosyadan oluşmaktadır:

### 1. `Araba.cs`
- **Görevi:** Araba sınıfının tanımlandığı ve kapsülleme işleminin uygulandığı dosyadır.
- **Özellikler:**
  - `Marka`: Arabanın markasını temsil eder.
  - `Model`: Arabanın modelini temsil eder.
  - `Renk`: Arabanın rengini temsil eder.
  - `KapiSayisi`: Arabanın kapı sayısını temsil eder. **Encapsulation** ile yalnızca 2 veya 4 değerleri kabul edilir. Geçersiz bir değer atanırsa, kapı sayısına -1 atanır ve bir uyarı mesajı gösterilir.

#### Örnek Kullanım:
```csharp
Araba araba1 = new Araba
{
    Marka = "Toyota",
    Model = "Corolla",
    Renk = "Beyaz",
    KapiSayisi = 4
};
```

### 2. `Program.cs`
- **Görevi:** Araba sınıfını kullanarak nesneler oluşturur ve bu nesnelerin özelliklerini kontrol eder.
- **Ana İşlemler:**
  - Geçerli ve geçersiz kapı sayılarıyla araba nesneleri oluşturur.
  - `BilgiYazdir()` metodu ile araba özelliklerini konsola yazdırır.

#### Örnek Kullanım:
```csharp
araba1.BilgiYazdir();
```

## Çalıştırma Adımları

1. **Proje Dizini:**
   - `Solution Explorer` üzerinde iki dosya oluşturulmalıdır:
     - `Araba.cs`: Araba sınıfını ve encapsulation işlemini içerir.
     - `Program.cs`: Araba sınıfını kullanarak nesneler oluşturur ve test eder.

2. **Namespace Kullanımı:**
   - `Program.cs` dosyasında `using ArabaUygulamasi;` satırı eklenerek "Araba" sınıfı erişilebilir hale getirilir.

3. **Kodun Çalıştırılması:**
   - `Program.cs` dosyasını çalıştırarak arabalar ve ilgili uyarı mesajları konsola yazdırılır.

## Örnek Çıktı

### Geçerli Kapı Sayısı:
```
Marka: Toyota, Model: Corolla, Renk: Beyaz, Kapı Sayısı: 4
```

### Geçersiz Kapı Sayısı:
```
Geçersiz Kapı Sayısı! (Sadece 2 veya 4 olabilir)
Marka: Honda, Model: Civic, Renk: Kırmızı, Kapı Sayısı: -1
```

## Kavramlar

- **Encapsulation:** Veri erişimini kısıtlamak ve yalnızca geçerli işlemlere izin vermek için kullanılır.
- **Property:** Bir sınıfın özelliklerini tanımlamak için kullanılır.
- **Namespace:** Sınıfların organize edilmesini sağlar.

Bu proje, nesne tabanlı programlama ve kapsülleme kavramlarını öğrenmek ve uygulamak için iyi bir başlangıçtır!

