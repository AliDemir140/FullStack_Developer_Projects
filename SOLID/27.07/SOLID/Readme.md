# (S)ingle Responsibility Principle
Her nesnenin ya da metodun sadece 1 sorumluluðu olmalýdýr, sadece o iþi yapmalý ve o iþten sorumlu olmalýdýr.

Böylece bir deðiþiklik yapýlacaðýnda, sadece bir nedene dayandýrýlýr.

# (O)pen/Closed Principle
Nesneler ya da metotlar geniþlemeye açýk, ancak deðiþikliklere kapalý olmalýdýr. 

Projede önceden yazýlan kodlarý deðiþtirerek deðil, var olan kodlara yeni eklemeler yaparak sorunlarý çözmeliyiz.


# (L)iskov's Substitution Principle
Nesneler, program çalýþýrken sorun yaratmadan kendi alt özellikleriyle deðiþtirilebilir olmalýdýr. 

Türemiþ class'lar, base class'ýn tüm özelliklerini kullanmak zorundadýr. Böylece gereksiz kod yýðýný oluþmamýþ olur. 


# (I)nterface Segregation Principle
Nesneler ihtiyaç duymadýklarý interface'lerden mümkün olduðunca ayrýþtýrýlmalýdýr.

Kullanýlmayan ya da ihtiyaç duyulmayan özellikler bulunmamalýdýr.

# (D)ependency Inversion Principle
Yüksek seviyeli class'lar, düþük seviyeli class'lara baðlý olmamalýdýr. Alt class'larda yapýlan deðiþiklikler üst class'larý etkilememelidir. 

Tek parça devasa bir class oluþturmak yerine, kendi iþlerini yapan küçük parçalar oluþturmak gerekmektedir.
