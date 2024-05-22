using Task4;

Console.WriteLine("Товар:");
Goods goods = new Goods();
goods.Name = "шпроты";
goods.ExpirationDate = DateTime.Now;
goods.Price = 245.2;

Console.WriteLine(goods.ToString());

Console.WriteLine("Пациент");
Patient patient = new Patient();
patient.Name = "Лизунов Григорий Константинович";
patient.BirthDate = DateTime.Now;
patient.Policy = 98;

Console.WriteLine(patient.ToString());