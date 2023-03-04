namespace prak5;

/// <summary>
/// Класс Program
/// здесь описываем логику приложения
/// вызываем нужные методы пишем обработчики и тд
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine(
                "Выберите пункт \n 1: Просмотреть существующие данные. \n 2: Добавить данные в БД. \n 3: Закрыть меню");
            int res = Convert.ToInt32(Console.ReadLine());
            switch (res)
            {
                case 1:
                    bool a = true;
                    while (a)
                    {
                        Console.WriteLine("Получить данные о \n 1: Водителях. \n 2: Типах автомобилей. \n 3: Категорях прав \n 4: Автомобилях \n 5: Маршрутах \n 6: Рейсах \n 7: Exit");
                        res = Convert.ToInt32(Console.ReadLine());
                        switch (res)
                        {
                            case 1:
                            {
                                DatabaseRequests.GetDriverQuery();
                                Console.WriteLine();
                                break;
                            }
                            case 2:
                            {
                                DatabaseRequests.GetTypeCarQuery();
                                Console.WriteLine();
                                break;
                            }
                            case 3:
                            {
                                DatabaseRequests.GetDriverRightsCategoryQuery(3);
                                Console.WriteLine();
                                break;
                            }
                            case 4:
                            {
                                DatabaseRequests.GetCarQuery();
                                Console.WriteLine();
                                break;
                            }
                            case 5:
                            {
                                DatabaseRequests.GetItineraryQuery();
                                Console.WriteLine();
                                break;
                            }
                            case 6:
                            {
                                DatabaseRequests.GetRouteQuery();
                                Console.WriteLine();
                                break;
                            }
                            case 7: a = false; break;
                        }
                    } break;
                case 2:
                        Console.WriteLine("Добавить в БД \n 1: Водителя. \n 2: Тип автомобиля. \n 3: Категорию прав \n 4: Автомобиль \n 5: Маршрут \n 6: Рейс \n 7: Exit");
                        res = Convert.ToInt32(Console.ReadLine());
                        switch (res)
                        {
                            case 1:
                            {
                                DatabaseRequests.AddDriverQuery("Денис", "Иванов", DateTime.Parse("1997.01.12"));
                                break;
                            }
                            case 2:
                            {
                                DatabaseRequests.AddTypeCarQuery("Воздушный");
                                break;
                            }
                            case 3:
                            {
                                DatabaseRequests.AddRightsCategoryQuery("C");
                                DatabaseRequests.AddDriverRightsCategoryQuery(4, 4);
                                break;
                            }
                            case 4:
                            {
                                DatabaseRequests.AddCarQuery(3, "Priora", "54GGG38C", 4);
                                break;
                            }
                            case 5:
                            {
                                DatabaseRequests.AddItineraryQuery("Омск");
                                break;
                            }
                            case 6:
                            {
                                DatabaseRequests.AddRouteQuery(3, 4, 2, 4);
                                break;
                            }
                            case 7: break;
                        } break;
                case 3: return;
            }
        }

        // // Вызовем метод для получения данных о водителях
        //     DatabaseRequests.GetDriverQuery();
        //     Console.WriteLine();
        //     // Добавим нового водителя в БД
        //     DatabaseRequests.AddDriverQuery("Денис", "Иванов", DateTime.Parse("1997.01.12"));
        //     // Вызовем метод для получения данных о водителях
        //     DatabaseRequests.GetDriverQuery();
        //
        //     // Вызовем метод для получения данных о типах автомобилей
        //     DatabaseRequests.GetTypeCarQuery();
        //     Console.WriteLine();
        //     // Добавим новый тип автомобиля в БД
        //     DatabaseRequests.AddTypeCarQuery("Воздушный");
        //     // Вызовем метод для получения данных о типах автомобилей
        //     DatabaseRequests.GetTypeCarQuery();
        //
        //     // Вывод метода для прав
        //     DatabaseRequests.GetDriverRightsCategoryQuery(3);
        //     Console.WriteLine();
        //
        //     DatabaseRequests.AddRightsCategoryQuery("C");
        //     DatabaseRequests.AddDriverRightsCategoryQuery(4, 4);
        //
        //     DatabaseRequests.GetDriverRightsCategoryQuery(4);
        //
        //     // Вывод машины
        //     DatabaseRequests.GetCarQuery();
        //     Console.WriteLine();
        //
        //     DatabaseRequests.AddCarQuery(3, "Priora", "54GGG38C", 4);
        //
        //     DatabaseRequests.GetCarQuery();
        //
        //     // Вывод для маршрута 
        //     DatabaseRequests.GetItineraryQuery();
        //     Console.WriteLine();
        //
        //     DatabaseRequests.AddItineraryQuery("Омск");
        //
        //     DatabaseRequests.GetItineraryQuery();
        //
        //     // Вывод рейса
        //     DatabaseRequests.GetRouteQuery();
        //     Console.WriteLine();
        //
        //     DatabaseRequests.AddRouteQuery(4, 5, 3, 4);
        //
        //     DatabaseRequests.GetRouteQuery();
        
    }
}
