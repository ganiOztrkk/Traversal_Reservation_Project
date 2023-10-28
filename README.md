# Traversal Reservation Project / Tur Rezervasyon Projesi


Proje Admin, User ve karşılama sayfası olarak 3 temel panelden oluşuyor. Admin tarafından dinamik olarak CRUD işlemlerinin gerçekleştirildiği bir Tur Rezervasyon projesi olarak değerlendirebiliriz.
Projede kullanıcı, admin tarafından oluşturulan turları görüntülüyor ve turlara rezervasyon talebinde bulunuyor.

Projeyi Core 7.0 ile geliştirdim ve geliştirmeyi veritabanını dockerize ederek projeme dahil ettim.

Geliştirme yaklaşımı olarak N Katmanlı Mimari yapısını kullandım. Projeyi daha yönetilebilir kılmak için Generic Repository Design Pattern, CQRS Desing Pattern, Unit Of Work gibi yaklaşımlar kullanarak SOLID prensiplerini gözetmeye çalıştım.

Veritabanı işlemleri için Entity Framework , oturum yönetimi için Session ve arayüz tasarımı için Bootstrap, CSS ve HTML kullandım.


## Kullanılan Teknoloji ve Yaklaşımlar

- N Katmanlı Mimari
- Generic Repository Design Pattern
- CQRS Design Pattern
- MediatR
- Unit Of Work
- Fluent Validation
- Data Transfer Objects
- Entity Framework
- Code First SQL Veritabanı Yönetimi
- Identity
- Ajax
- AutoMapper
- SignalR
- Web API
- PostgreSQL
- View Component
- View Model
- Session ile Oturum Yönetimi
- Bootstrap
- HTML5
- Postman
- Authentication
- Authorization

  
## Ekran Görüntüleri

![Uygulama Ekran Görüntüsü](https://media.licdn.com/dms/image/D4D22AQGkINjSYAZXzg/feedshare-shrink_2048_1536/0/1698516587564?e=1701302400&v=beta&t=fYKYqvF8ejzp-OY_HENbNYFiRfv0gOS398nGTcN2tCE)

![Uygulama Ekran Görüntüsü](https://media.licdn.com/dms/image/D4D22AQF_8526zYuvog/feedshare-shrink_2048_1536/0/1698516581207?e=1701302400&v=beta&t=O0SRuUV8c-bZ6kOhO70_ic5MjwZDIzCPKomiOdTa8f0)

![Uygulama Ekran Görüntüsü](https://media.licdn.com/dms/image/D4D22AQFxkacD8aNNYQ/feedshare-shrink_2048_1536/0/1698516585159?e=1701302400&v=beta&t=H9A_BImYnATa1HnHEuDShxEdS0jaLa0uy3XZDG7Z_bQ)

![Uygulama Ekran Görüntüsü](https://media.licdn.com/dms/image/D4D22AQHjImsnrUTpYg/feedshare-shrink_2048_1536/0/1698516587929?e=1701302400&v=beta&t=DuUoXvO7Qbveyt07Ow4KAASsdANOCYF8JH8yVuPkbm8)

![Uygulama Ekran Görüntüsü](https://media.licdn.com/dms/image/D4D22AQEU8yILAVbRjg/feedshare-shrink_2048_1536/0/1698516587284?e=1701302400&v=beta&t=YCaCHAG-Ykj5kjAusfoiE4ISMPsezW9K4cxmsF1y1Rw)

![Uygulama Ekran Görüntüsü](https://media.licdn.com/dms/image/D4D22AQGQI27oUT9uVA/feedshare-shrink_2048_1536/0/1698516586709?e=1701302400&v=beta&t=QDIjbXwhRu3Gnnc2xieUQIst7zawRFy7bzGcD0KXlr0)

![Uygulama Ekran Görüntüsü](https://media.licdn.com/dms/image/D4D22AQE_8OA9yVrBTw/feedshare-shrink_2048_1536/0/1698516583198?e=1701302400&v=beta&t=PcRZFMYy-ZIJ2TEHciCRrCYx27b5TMCtGqEfxoZTBJ8)

![Uygulama Ekran Görüntüsü](https://media.licdn.com/dms/image/D4D22AQGJzn74nHrN_A/feedshare-shrink_2048_1536/0/1698516585479?e=1701302400&v=beta&t=uA9i4LU8fgKlWE1AvmHjDEtUh7yAASnuf2xZXwQt3nc)

![Uygulama Ekran Görüntüsü](https://media.licdn.com/dms/image/D4D22AQHGMu1VneGeSg/feedshare-shrink_2048_1536/0/1698516587300?e=1701302400&v=beta&t=swL45PSwiR6K7MdZ4rBb83MjrAjQPymTLQP8iYo36aU)

![Uygulama Ekran Görüntüsü](https://media.licdn.com/dms/image/D4D22AQF-SS6L9-TxuQ/feedshare-shrink_2048_1536/0/1698516586588?e=1701302400&v=beta&t=yNK-sPHOn0FdH_U6XnJbJiZLBTJx-_i1j_FeJRFr_rA)

![Uygulama Ekran Görüntüsü](https://media.licdn.com/dms/image/D4D22AQGnuKeokB5mMQ/feedshare-shrink_2048_1536/0/1698516582334?e=1701302400&v=beta&t=tmRX7IgOV-0ot_03m-ce8efHD5lZVDicU0cqA8cauVg)

![Uygulama Ekran Görüntüsü](https://media.licdn.com/dms/image/D4D22AQEicNxk3DC2JA/feedshare-shrink_2048_1536/0/1698516582413?e=1701302400&v=beta&t=SntofczBnru04SgyOL4qU6cLJGpuEYi7q-umqtnBHO0)

![Uygulama Ekran Görüntüsü](https://media.licdn.com/dms/image/D4D22AQF-hvwf3XWDkw/feedshare-shrink_2048_1536/0/1698516582132?e=1701302400&v=beta&t=XiozM_CMeSWKw_E5Uo8L9FoTGTmpZ6amscy3UmiL6ds)

![Uygulama Ekran Görüntüsü](https://media.licdn.com/dms/image/D4D22AQGVWEX_PnA8Ag/feedshare-shrink_2048_1536/0/1698516582961?e=1701302400&v=beta&t=a7fq_mLSEcETR8Ak8GIzCz7rZOj8_7C7uz36YKGEw_s)
