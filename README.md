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
