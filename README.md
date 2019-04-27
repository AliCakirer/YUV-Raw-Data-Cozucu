# YUV-Raw-Data-Cozucu
.yuv uzantılı dosyalar üzerinde oynamalar yapmaya yarayan program.

### Temel Bilgiler

Video dosyaları genellikle framelerden oluşur. Yani art arda gelen fotoğraflardan oluşur. Yuv dosyalarıda öyledir. Bizim projemizde yuv formatının 3 şeklini kullandık. Bunlar ; 4.4.4 -4.2.2 – 4.2.0 . Bu formatlarda ki ilk değer y ‘ yi diğerleri de sırasıylar uv ‘ yi belirtir. Biz y değerini kullandığımız için uv değerlerini bizim için önemsiz. Y değeri siyah-beyazı belirtir. Diğer uv ler renk değerleridir. Bu nedenle program çıktımız siyah beyaz videolar olacaktır.

Dönüştürme işleminde dediğimiz gibi y değerini kullandık. Bu y değerini yuv dosyasından alabilmek için bazı matematiksel işlemler yapmak gerekir. Bu işlemler formattan formata değişecektir. 

Örneğin dosyamız 50*20lik  bir .yuv dosyası olsun formatı ise 4.2.0 olsun. Burda y değeri framelerin genişlik ve yüksekliklerinin çarpımından bulunur yani 50*20=1000 bit olur. 

### Dönüştürme işlemi ve menü görünümü

![as](https://user-images.githubusercontent.com/28457032/56849710-98717680-6900-11e9-9166-9e3eca4e814c.png)
