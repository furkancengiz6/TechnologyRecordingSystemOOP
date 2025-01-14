


using TechnologyRecordingSystemOOP.entities.concretes;

bool continueProgress = true;


while (continueProgress)
{
    Console.WriteLine("Ürün üretmek için bir seçim yapınız:");
    Console.WriteLine("1 - Telefon üret");
    Console.WriteLine("2 - Bilgisayar üret");
    Console.Write("Seçiminiz: ");

   string choice = Console.ReadLine();

    if (choice == "1")
    {
        var phone = new Phone();
        phone.Name = Console.ReadLine();
        Console.Write("Telefonun açıklaması: ");
        phone.Description = Console.ReadLine();
        Console.Write("Telefonun işletim sistemi: ");
        phone.OperatingSystem = Console.ReadLine();
        Console.Write("Telefonun TR Lisans bilgisi: ");
        phone.TrLisans = Console.ReadLine();
        Console.WriteLine("\nTelefon başarıyla üretildi!");
        phone.GetProductName();

    }
    else if (choice == "2") 
    {
        var computer = new Computer();
        Console.Write("Bilgisayarın adı: ");
        computer.Name = Console.ReadLine();
        Console.Write("Bilgisayarın açıklaması: ");
        computer.Description = Console.ReadLine();
        Console.Write("Bilgisayarın işletim sistemi: ");
        computer.OperatingSystem = Console.ReadLine();

        bool usbInputValid = false;
        while (!usbInputValid) 
        {
            Console.Write("USB giriş sayısı (2 veya 4 olmalı): ");

            if(int.TryParse(Console.ReadLine(),out int usbInput) && (usbInput == 2 || usbInput == 4)) 
            {
                computer.NumberOfUsbInputs = usbInput;
                usbInputValid = true;
            
            }
            else {
                Console.WriteLine("Geçersiz giriş. Lütfen 2 veya 4 giriniz.");
            }


        }

        Console.Write("Bluetooth özelliği (Evet/Hayır): ");
        string bluetoothInput = Console.ReadLine()?.ToLower();
        computer.BluetoothEnabled = bluetoothInput == "evet";

        Console.WriteLine("\nBilgisayar başarıyla üretildi!");
        computer.GetProductName();
        computer.InfoPrint();
    }
    else
    {
        Console.WriteLine("Geçersiz seçim. Lütfen 1 veya 2 giriniz.");
        continue;
    }
    Console.Write("\nBaşka bir ürün üretmek istiyor musunuz? (Evet/Hayır): ");
    string continueAnswer = Console.ReadLine()?.ToLower();

    continueProgress = continueAnswer == "evet";

    if (!continueProgress) { Console.WriteLine("İyi günler dileriz!"); }
















}
