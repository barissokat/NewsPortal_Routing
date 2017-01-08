# NewsPortal_Routing

<h3>Bu proje ASP.NET MVC projelerinde yönlendirme konusunun kavranması amacıyla yapılmıştır.</h3>

## Özet

Bu projede **yönlendirme** konusu kavranabilmesi için, haber sitesi baz alınıp, bu sitede bulunabilecek sayfalara göre yönlendirmeler tanımlanmıştır. Bu haber sitesinde, kategori, haber ve arşiv sayfaları için yönlendirmeler yapılmıştır.

## Yönlendirmelerin Test Edilmesi

#### Anasayfa'ya Özel Route

Tek bir sayfa olarak düşünülmüştür. Sadece içeriği değişip, sayfa sabit olduğundan route ayarlarında doğrudan link tanımlanmıştır.

Anasayfa'ya aşağıdaki ekran görüntüsünde bulunan link ile ulaşılabilir.

![alt tag](https://github.com/bsokat/NewsPortal_Routing/blob/master/Source/HomePage1.png)

#### Kategori Sayfalarına Özel Route

Site içerisinde bir çok kategori ve bu kategorilerin alt kategorileri olacağı düşünülmüştür. Linkin kategori sayfasına yönleneceğinin belirtilmesi için link **category** ismiyle başlamaktadır. Sitedeki kategorilerin en yüksek kırılım sayısı veritabanından sorgulanıp öğrenildikten sonra route tanımlaması dinamik olarak yapılmalıdır. Ancak bu projede veritabanı bulunmadığı için kırılım sayısı rastgele olarak 3 seçilmiştir. Yani bir kategorinin kendisiyle hariç en fazla 2 tane alt kategorisi bulunmaktadır. Bir kategori sayfası açıldığında o sayfada, açılan kategoriye sahip tüm haberler listelenecektir.

Kategori sayfalarına aşağıdaki ekran görüntüsünde bulunan linkler ile ulaşılabilir.

Altkategorisi bulunmayan kategori sayfanın linki,

![alt tag](https://github.com/bsokat/NewsPortal_Routing/blob/master/Source/Category1.png)

Bir altkategorisi bulunan kategori sayfanın linki,

![alt tag](https://github.com/bsokat/NewsPortal_Routing/blob/master/Source/Category2.png)

İki altkategorisi bulunan kategori sayfanın linki,

![alt tag](https://github.com/bsokat/NewsPortal_Routing/blob/master/Source/Category3.png)

Kırılım sayısı aşağıdaki ekran görüntüsünde olduğu gibi 3'ü geçtiği için, yani 4 olduğu için istenilen kategori sayfasına ulaşılamamaktadır.

![alt tag](https://github.com/bsokat/NewsPortal_Routing/blob/master/Source/Category4.png)

Rota kısıtlaması ile kategori listesi dışında bir kategori sayfasına ulaşılmaya çalışıldığı zaman alttaki ekran görüntüsündeki gibi sayfaya ulaşılmamaktadır.

![alt tag](https://github.com/bsokat/NewsPortal_Routing/blob/master/Source/Category5.png)

#### Haber Sayfalarına Özel Route

Site içerisinde birçok haber bulunduğu ve bu haberlerin sadece bir kategoriye ait olduğu düşünülmüştür. Bu nedenle haber linki tanımlanırken haberin kategorisi de tanımlanmıştır. Linkin haber sayfasına yönleneceğinin belirtilmesi için **news** ismiyle başlamaktadır.

Haber sayfalarına aşağıdaki ekran görüntüsünde bulunan link ile ulaşılabilir.

![alt tag](https://github.com/bsokat/NewsPortal_Routing/blob/master/Source/News1.png)

> Kategori sayfalarında olduğu gibi route kısıtlamalarında bulunmayan kategoriler girildiğinde ya da kırılım sayısı tanımlanan kırılım sayısını geçtiği zaman, istenilen sayfalar gösterilemeyecektir.