//Fabrika Metot: Bir nesne oluşturmak istediğimizde belirli bir tasarıma ait olacak şekilde tanımlanacaksa o halde biz bu işlemleri fabrika metot vasıtasıyla seri olarak oluşturabiliriz.



//Mage: Büyücü
//Warrior: Savaşçı
//Rogue: küçük savaşçı
//Hunter: Okçu


using FactoryMethodPattern.Abstracts;
using FactoryMethodPattern.Concretes;
using FactoryMethodPattern.Creator.Abstracts;
using FactoryMethodPattern.Creator.Concretes;

BaseCharacterCreator mageCreator = new MageCreator();
BaseCharacterCreator warriorCreator= new WarriorCreator();

ICharacter mage = mageCreator.CreateCharacter();

ICharacter warrior= warriorCreator.CreateCharacter();






mage.Attack();
warrior.Defense();
warrior.Attack();
mage.Defense();





Mage mage1 = new Mage();
mage1.Attack();

mage1.Defense();