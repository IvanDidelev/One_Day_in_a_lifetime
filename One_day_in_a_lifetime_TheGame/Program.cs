
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
class Program
{
    static uint locationNumber = 1;
    static uint Eloquence = 1;
    static uint Speed = 1;
    static uint aPleadingLook = 1;
    
    static bool StudentIdCard = false;
    static uint Condoms = 0;
    static uint Money = 0;

    static void Main(string[] args)
    {
        Introduction();
        while (true)
        {
            if (locationNumber == 1) {StartLocationHome(); }
            else if (locationNumber == 2) {CollageLocation(); }
            else if (locationNumber == 3) {LoveStory(); }
            else if (locationNumber == 4) { break; }
        }
    }
    static int CheckingAvailability(int numberOfSolutions)
    {
        string input = Console.ReadLine();
        int numberOfCondoms;
        bool isConverted = int.TryParse(input, out numberOfCondoms);
        bool isInRange = numberOfCondoms >= 1 && numberOfCondoms <= numberOfSolutions;

        while (!isConverted || !isInRange)
        {
            Console.WriteLine("Такого вариана нету! Выбирай из того что есть;)");
            input = Console.ReadLine();
            isConverted = int.TryParse(input, out numberOfCondoms);
            isInRange = numberOfCondoms >= 1 && numberOfCondoms <= numberOfSolutions;
        }

        return numberOfCondoms;
    }
    static void GameOver()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("GAME OVER!");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Не растрайвайтесь, попробуйте еще раз!");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.ReadLine();
        Console.WriteLine("Нажмите Enter что-бы начать заново");
        Console.ReadLine();
        Console.Clear();
    }
    static void YouWin()
    {
        int userInput;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("***************************************************");
        Console.WriteLine("YOU WIN!\n");
        Console.ReadLine();
        Console.WriteLine("Поздраляю вы прошли игру, хотите пройти еще раз?\n" +
                          "1. Да                                      2.Нет\n");
        userInput = CheckingAvailability(2);
        if(userInput == 1)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Нажмите Enter что-бы начать заново");
            Console.ReadLine();
            Console.Clear();

        }else if(userInput == 2) 
        {
            Console.WriteLine("Тогда спасибо за прохождение, еще увидися!");
            Console.ReadLine();
            locationNumber = 4;
            
        }

    }
    static void EmptyPocet()
    {
        int userImput;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Махнув рукой вы отпраильсь в дорогу.");
        Console.ReadLine();
        Console.WriteLine("Спустя несколько километров пути, вдали вы видете прекрасный силуэт серого цвета,\n " +
            "который возвышвется над верхушками деревьев. Пройдя еще немного вы наконецто оказались перед вратами ВКУиНТа\n" +
            "Войдя в них вы прошли ко входу\n" +
            "Вы наконец вошли во внутрь, но на входе вас останавливает охрана \n" +
            "- Предъявите студенческий");
        Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Ваши действия: 1. Осмотреть карман\n" +
                          "               2. Ответить как ОЧЕНЬ дерзкий тип\n" +
                          "               3. Применить навык \"Красноречие\" \n   ");
        userImput = CheckingAvailability(3);
        Console.Clear();
        if (userImput == 1)
        {
            if (StudentIdCard)
                Console.WriteLine("Студенческий находится в кармане");
            else
                Console.WriteLine("Студенческого в кармане нет");
            if (Condoms == 1)
                Console.WriteLine("Шапки неведимки у вас в кармане");
            else
                Console.WriteLine("У вас в кармане не шапок неведимок");
            Console.WriteLine($"В вашем кармане {Money} руб.");


            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Console.WriteLine("Посмотрев в карман вы резко вспомнили как забыли студенческий дома.\n" +
                              "- Простите у меня нет студенческого.\n" +
                              "- Тогда пошел вон отсюда щенок.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Раздосадованный вы покинули колледж.\n" +
                              "Выйдя из ворот вы слышыте рев мотора и скрип колес.\n" +
                              "Про себя в голове вы подумали \"Что за конченный ублюдок?\"\n" +
                              "И вдруг этот турбированный демон подлетает к вам. Вы уже были готовы дать по тапкам, но тонированная завеса опустилась\n" +
                              "И за рулем оказался ваш друг и сосед Граф Беляш.\n");
            Console.WriteLine("- Бро, что случилось?");
            Console.ReadLine();
            Console.WriteLine("- Меня не  впустили в колледж.");
            Console.ReadLine();
            Console.WriteLine("- Бро, забей погнали полетаем.");
            Console.ReadLine();
            Console.WriteLine("- Слушай, ты прав.LETS GOOOOOO!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Но это было очень опрометчивое решение.\n" +
                              "Граф оказался тем еще хасанатором, и набрав скорость 140 км/ч он влетел в столб\n" +
                              "На нем не было ни царапины, а вот вы вылетели через лобовое стекло и разбились насмерть.\n");
            GameOver();

        }
        else if (userImput == 2)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("- Хей малая, ты в курсе с кем базаришь?!\n" +
                              "Одно мое слово и ты станешь одной из тех людей про кого байки оврага слогают\n" +
                              "Надеюсь бейба мы поняли друг друга и ты свалишь с прохода.\n");
            Console.ReadLine();
            Console.WriteLine("- Ты че щегол...");
            Console.ReadLine();
            Console.WriteLine("За осорбления вы получили конкретынх люлей и были унижены\n" +
                              "Вас обоссали, сделали вам антиэрокез и выкинули на улицу\n");
            Console.ReadLine();
            Console.WriteLine("Несправившись с таким позором вы решили уйти жить в лес и о вас больше никто ничего не слышал\n" +
                              "Но ходит легенда что кто-то похожий на человека обитает в лесу возможно это ...");
            GameOver();

        }
        else if (userImput == 3)
        {
            Eloquence = Eloquence - 1;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Вау! Вы применили навык!");
            Console.WriteLine("Что же такое навык? Навык - это особая способность которая помогает вам выйти из сложных ситуаций\n" +
                              $"Количество навыков ограниченно. Ваши навыки красноречие - {Eloquence} шт., Быстрые ноги - {Speed} шт., Умоляющий взгляд - {aPleadingLook} шт.");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("С помощю своего навыка пафасно заговаривать зубы вы все таки прошли...");
            locationNumber = 2;
        }
    }
    static void WhatsAppMoment()
    {
        int userInput;
        Console.WriteLine("Пройдя мимо этих полупокеров, проходя дальше по коридору вы увидели\n" +
                                        "Ничего такую ципу, как раз в вашем вкусе.\n" +
                                        "Девченка на вид лет 15, вот вот закончила школу, в анимешном свитере на 10 размеров больше нее\n" +
                                        "С белыми как молоко волосами, и черными как гиматома губами.");
        Console.ReadLine();
        Console.WriteLine(" '- Черт возьми вот это ципа' - подумали вы. И тут вас посетила мысль...");
        Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Что же вы выберите: 1. Забить на нее и пойти далльше на пару.\n" +
                          "                    2. Пойти к этой крошке и попытать свою удачу.\n ");
        Console.ForegroundColor = ConsoleColor.White;
        userInput = CheckingAvailability(2);
        if (userInput == 1)
        {
            Console.Clear();
            Console.WriteLine("Выключив сердце и включив голову вы поняли что телкам нужно только одно\n" +
                              "Это ваши деньги и время, а так как все ваши сберижения ухродят на кефир, а время на прокачку пресса,\n" +
                             "то вы решили прокачать свой мозг.\n ");
            Console.ReadLine();
            Console.WriteLine("Вы вошли в кабинет.\n ");
            Console.ReadLine();
            Console.WriteLine("Осмотрев кабинет, вы видете вашего друга скинхеда, и естственно вы решаете подсесть у нему.\n");
            Console.ReadLine();
            Console.WriteLine("- Зарова, дружище!\n");
            Console.ReadLine();
            Console.WriteLine("- Привет, Ваван\n");
            Console.ReadLine();
            Console.WriteLine("- Как ты, как жизнь?\n");
            Console.ReadLine();
            Console.WriteLine("- Та как обычно, вчера щеманул пару нефоров, похавл гвоздей, отпалировал берци и лег баеньки.\n" +
                              "  Ты как?\n");
            Console.ReadLine();
            Console.WriteLine("- Та лучше всех, отыграл несколько каточек в танки, каждому пробил бампер и залктол баблишка,\n" +
                              " ну конечно парочку ботов написал, ну и попил кифирчика и лег спатки.\n");
            Console.WriteLine("- Ну красавчик что сказать.\n");
            Console.ReadLine();
            Console.WriteLine("- Дружище я пока посплю, если что толкни меня пж.\n");
            Console.ReadLine();
            Console.WriteLine("- Хорошо.\n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Прошла пара...\n");
            Console.ReadLine();
            Console.WriteLine("- Ох, не плохо покимарил.\n");
            Console.ReadLine();
            Console.WriteLine("- Дружище как тебе идея свалить от сюда ?\n");
            Console.ReadLine();
            Console.WriteLine("- Черт возьми я даже не знаю, а сколько пар осталось?\n");
            Console.ReadLine();
            Console.WriteLine("Вообще одна, но мне чет надоело сидеть в этом унылом месте. Так что ты со мной?\n");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Что вы выберите? : 1. Остаться\n " +
                              "                  2. Уйти\n   ");
            Console.ForegroundColor = ConsoleColor.White;
            userInput = CheckingAvailability(2);
            Console.Clear();
            if (userInput == 1)
            {
                Console.WriteLine("Знаешь дружище, я так подумал, я наверное останусь\n");
                Console.ReadLine();
                Console.WriteLine("Ну и ладно, я пошел!\n");
                Console.ReadLine();
                Console.Write("Спустя время...");
                Console.ReadLine();
                Console.WriteLine("Оставшись на последнююю пару вы не прогадали. \n" +
                                  "Под конец последней пары в ваш кабинет зашла Алла Юрьевна и объявила,\n" +
                                  "что все присутствующие на паре освобождаются от экзаменов и отпраляются на неделю каникул\n");
                Console.ReadLine();
                Console.WriteLine("Переполненный счастьем вы покидаете колледж и со спокойной душой отпраляетесь играть в танки ...\n");
                YouWin();
            }
            else if (userInput == 2)
            {
                Console.WriteLine("Ладно, пойдем отсюда.\n");
                Console.ReadLine();
                Console.WriteLine("Покинув колледж вы со своим другом отправились прогуливаться по району.\n" +
                                  "Осматривая местные красоты вы слышите...\n");
                Console.ReadLine();
                Console.WriteLine("- Эй вы, два олуха!\n");
                Console.ReadLine();
                Console.WriteLine("Вы решиле оглянуться. И увидели за своей спиной бандку редана, которая была явно не позитивно настроенна.\n");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ваши дейстивия: 1. Подойти к ним\n" +
                                  "                2. Применить навык 'быстрые ноги'\n");
                Console.ForegroundColor = ConsoleColor.White;
                userInput = CheckingAvailability(2);
                if (userInput == 1)
                {
                    Console.Clear();
                    Console.ReadLine();
                    Console.WriteLine("- Вы что-то хотели ?");
                    Console.ReadLine();
                    Console.WriteLine("- Да. Вы как я посмотрю скинхеды, а у нас таких не любят, так что ...\n");
                    Console.ReadLine();
                    Console.WriteLine("Не успев закончить фразу ваш дружище прописывает до блеска начищенным берцем обидчику по щам\n");
                    Console.WriteLine("Но ваш друг не учел ваших и его физических способностей,\n" +
                                      "Ну и в количесвте вы тоже знатно проигрывали.");
                    Console.ReadLine();
                    Console.WriteLine("По итогу вас с вашим патлатым другом отвезли в реанимацию\n " +
                                      "В которой вы проведете ближайшие несколько месяцев...");
                    GameOver();

                }
                else if (userInput == 2)
                {
                    Speed = Speed - 1;
                    Console.Clear();
                    Console.WriteLine("Вы применили навык!\n");
                    Console.WriteLine($"Остатки ваших навыков| Краснорчие {Eloquence} шт. , Быстрые ноги {Speed} шт. , Молящий взгляд {aPleadingLook} шт.\n");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Вы экстенно покинули место кипиша.\n" +
                                      "Вы бежали настолько быстро что не заметели как оказались у входа в свою квартиру.\n" +
                                      "Вы вошли в дом и закрылись там.\n");
                    Console.ReadLine();
                    Console.WriteLine("Вы просидели в квартире до конца дня ...");
                    YouWin();

                }
            }
        }
        else if (userInput == 2)
        {
            locationNumber = 3;

        }



    }
    static void CheckMoney(int price)
    {
        
        if(Money == 0 || Money < price )
        {
            Console.WriteLine($"Недостаточно  средств, на вашем счете {Money} руб.");
        }else 
        {
            Console.WriteLine("Оплаченно!");
        }

    }


    static void Introduction()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("                                 ДОБРО ПОЖАЛОВАТЬ!");
        Console.WriteLine("                 Всем привет! Добро пожаловать в игру 'One day in a lifetime...'.\n" +
                          " В этой игре вы будете играть за простого ВКУиНТовского студента Вавана и проживете его обычный день\n" +
                          "                                Главное это прожить день!\n " +
                          "                полный приключений, выборов и незабываймых ощущений!\n ");
        Console.WriteLine("********************************************************************************************************");
        Console.ReadLine();

        Console.WriteLine("########################################################################################################");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("                                     ДИСКЛЕЙМЕР                                   \n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("                  Даннная игра несет исключительно развлекательный характер.\n " +
                          " Она не несет цели кого-то оскрбить или унизить. Все совпадения с реальными лицами являются случайными.\n " +
                          "                  В игру НЕ РЕКОМЕНДУЕТСЯ играть лицам не достигшим 16 лет!");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("########################################################################################################");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Если вы ознакомились с дисклеймером тогда нажмите Enter и вперед!");
        Console.ReadLine();

        Console.Clear();


    }
    static void StartLocationHome()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Звенит будильник...\n" +
                         "Ваши действия: 1. Остановить будильник. Продолжить спать.\n" +
                         "               2. Выключить будильник. Встать с кровати\n" +
                         "               3. Отложить будильник на 30 минут\n");


        int userInput = CheckingAvailability(3);

        Console.Clear();
        if (userInput == 1)
        {
            Console.WriteLine("Это уже не первый будильник который вы отключили и далеко не первый пропущенный день,\n" +
                              "но этот будильник был последний. В связи с частыми прогулами вас отчислили из ВКУиНТа.\n" +
                              "По итогу ваша жизнь пошла подоткос и вы погибли.\n");
            GameOver();

        }
        else if (userInput == 2)
        {


            Console.WriteLine("Немного прийдя в себя вы поняли, что пора собираться в колледж.\n" +
                          "Ваши вещи разбросаны по вашей халупе и нужно их найти.\n" +
                          "Соберите базовый карман студента\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ваши действия: 1.Осмотреть халупу\n" +
                              "               2.Забить на вещи и отправиться в путь с пустыми карманами.");

            userInput = CheckingAvailability(2);
            Console.Clear();

            switch (userInput)
            {
                case 1:
                    {
                        while (true)
                        {

                            Console.WriteLine("Ваши действия:             1. Осмотреть стол\n" +
                                  "                           2. Осмотреть кровать.\n" +
                                  "                           3. Осмотреть шкаф\n " +
                                  "                          4. Осмотреть тумбочку\n" +
                                  "                           5. Закончить осмотр\n ");

                            userInput = CheckingAvailability(5);
                            Console.Clear();

                            if (userInput == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("На вашем столе полная помойка и что-бы тут что-то найти нужно постраться\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Ваши действия:           1. Поднять тетради\n" +
                                        "                         2. Заглянуть в тумбочку.\n" +
                                        "                         3. Посмотреть под клавиатуру\n ");
                                userInput = CheckingAvailability(3);
                                Console.Clear();
                                if (userInput == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("М-да, похоже вы зря потратили время, под тетрадями пусто\n");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.ReadLine();
                                }
                                else if (userInput == 2)
                                {

                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Среди всякого мелкого мусора, проводов и разного рода мукулатуры вы находите свой \n" +
                                        "студенческий билет и кладете его в карман\n");
                                    StudentIdCard = true;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                                else if (userInput == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Money += 100;
                                    Console.WriteLine("Ничего себе! Заглянув под клавиатуру вы нашли вашу заначку.\n" +
                                                      $"Теперь в вашем кармане лежит {Money} руб.\n ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                            }//Стол
                            else if (userInput == 2) //Кровать 
                            {   Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("Оу май...Неплохая находка. Теперь в вашем кармане лежит пачка шапок неведимок.\n");
                                Condoms += 1;
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else if (userInput == 3)//Шкаф 
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("Дааааа...Неплохая коллекция берцев, но это не то\n");
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else if (userInput == 4)//Тумбочка 
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("Ваша тумбочка скоро лопнет от переизбытка вещей, но к сожалению полезного там мало.\n");
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Green;

                            }
                            else if(userInput == 5)
                            {
                                break;
                            }
                        }
                        Console.Clear ();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Набрав полные карманы можно со спокойной совестью отправлятся в шарагу.\n");
                        Console.ReadLine();
                        locationNumber = 2;
                        break;

                    }
                case 2:
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Надеясь на то что сегодня будет легкий день вы решаете на собирать вещи,\n" +
                                          "а отправиться с пустыми карманами.  ");
                        Console.WriteLine();

                        Console.WriteLine("Ваван отправился в путь...\r\nПрийдя на остановку он понял что денег на маршрутку он не взял.\r\nИ он задумался как же поступить.\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("1.Забить на шарагу и топать домой играть в танки\n" +
                                          "2.Пойти в шарагу пешком ");

                        userInput = CheckingAvailability(2);
                        Console.Clear();
                        if (userInput == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Притопав назад домой и запустив своего игрового демона вы начали оформлять пробития.\r\nКак вдруг заскрипела дверь и в комнату неожидано вошел ваш отец.\r\nС озадаченным взглядом он посмотрел на вас и спросил:\r\n- Какого черта ты не на парах олух?\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("1.- Тебя интересовать не должно.\n" +
                                              "2.- У нас отменили пары.");
                            userInput = CheckingAvailability(2);
                            if (userInput == 1)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Услышав такую дерзость в свой адрес пахан решает офрмить пару пробитий уже вам.\r\nИ увы это ничем не контриться. Получив тяжкие травмы вы уже некогда не сможите востановиться.\nИ тогда вы понимаете что это была ваша последняя катка в танки...\n");
                                GameOver();
                            }
                            else if (userInput == 2)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Пахан верит вашей неуклюжей лжи и оставляет вас в покое");
                                Console.WriteLine();
                                Console.ReadLine();
                                Console.WriteLine("Далее...");
                                Console.ReadLine();
                                Console.WriteLine("Наступил вечер.\r\nОтцу пришло сообщение от куратора о том что пары сегодня все таки были.\nВ этот момент разъереный отец срывается с дивана и мчится к вам. Что бы вас уничтожить.\n");
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Ваши действия: 1. Применить навык \"Красноречие\" \n" +
                                                  "               2. Спрятаться под шконку");
                                Console.ForegroundColor = ConsoleColor.White;
                                userInput = CheckingAvailability(2);

                                switch (userInput)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Вау! Вы применили навык!");
                                            Console.WriteLine("Что же такое навык? Навык - это особая способность которая помогает вам выйти из сложных ситуаций\n" +
                                                              $"Количество навыков ограниченно. Ваши навыки красноречие - {Eloquence} шт., Быстрые ноги - {Speed} шт., Умоляющий взгляд - {aPleadingLook} шт.");

                                            Eloquence = Eloquence - 1;
                                            Console.ReadLine();
                                            Console.Clear();

                                            Console.WriteLine("Каким-то чудом ваш длинный язык вам помог и вы отделались парочкой словестных\r\nоскарблений на которые вам в принцепе было все равно.\n" +
                                                "После увлекательной беседы пахан покидает вашу сочевалню и вы остаетесь на едине с вашей танковой братвой и продолжаете\n" +
                                                "Пробивать броню, прокачивать пушки и принимать снаряды в башню...");

                                            Console.ReadLine();

                                            Console.WriteLine("Отыграв еще парочку каточек и офрмив несколько филигранных пробитий вы с чистой совестью и подгоревшей задницей\n" +
                                                "от косяков ваших тимейтов вы отправились спать. \n" +
                                                "На этом день закончился и вы может собой гордится что он прошел славно...");
                                            YouWin();
                                            break;
                                        }

                                    case 2:

                                        {
                                            Console.Clear();
                                            Console.WriteLine("В панике вы залетеле под кровать. Сидя там, покрытый с головы до ног мурашками, истекая холодным потом,\n" +
                                                "скрестив пальцы и моля бога вы надеетесь что вас не найдут. Но увы жизнь жестока и несправедлива.\n" +
                                                "Отец вас замечает и за шкирку достает вас из под кровати..." +
                                                "\nДостав вас из под кровати отец офрмляет вам парачку щииикарных хуков за лож, после чего ваша балбешка отлетает.");

                                            GameOver();
                                            break;
                                        }
                                }

                                Console.Clear();
                            }
                        }
                        else if (userInput == 2)
                        {
                            Console.Clear();
                            EmptyPocet();
                        }



                        break;
                    }

            }

        }
        else if (userInput == 3)
        {
            Console.WriteLine("Из-за того что вы отложиле будильник\r\nвы проспали и вам срочно нужно ехать в колледж");
            Console.WriteLine();
            Console.WriteLine("Ваван отправился в путь...\r\nПрийдя на остановку он понял что денег на маршрутку он не взял.\r\nИ он задумался как же поступить.\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1.Забить на шарагу и топать домой играть в танки\n" +
                              "2. Пойти в шарагу пешком ");

            userInput = CheckingAvailability(2);
            Console.Clear();
            if (userInput == 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Притопав назад домой и запустив своего игрового демона вы начали оформлять пробития.\r\nКак вдруг заскрипела дверь и в комнату неожидано вошел ваш отец.\r\nС озадаченным взглядом он посмотрел на вас и спросил:\r\n- Какого черта ты не на парах олух?\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1.- Тебя интересовать не должно.\n" +
                                  "2.- У нас отменили пары.");
                userInput = CheckingAvailability(2);
                if (userInput == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Услышав такую дерзость в свой адрес пахан решает офрмить пару пробитий уже вам.\r\nИ увы это ничем не контриться. Получив тяжкие травмы вы уже некогда не сможите востановиться.\nИ тогда вы понимаете что это была ваша последняя катка в танки...\n");
                    GameOver();
                }
                else if (userInput == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Пахан верит вашей неуклюжей лжи и оставляет вас в покое");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.WriteLine("Далее...");
                    Console.ReadLine();
                    Console.WriteLine("Наступил вечер.\r\nОтцу пришло сообщение от куратора о том что пары сегодня все таки были.\nВ этот момент разъереный отец срывается с дивана и мчится к вам. Что бы вас уничтожить.\n");
                    Console.ReadLine();
                    Console.WriteLine("Ваши действия: 1. Применить навык \"Красноречие\" \n" +
                                      "               2. Спрятаться под шконку");

                    userInput = CheckingAvailability(2);

                    switch (userInput)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("Вау! Вы применили навык!");
                                Console.WriteLine("Что же такое навык? Навык - это особая способность которая помогает вам выйти из сложных ситуаций\n" +
                                                  $"Количество навыков ограниченно. Ваши навыки красноречие - {Eloquence} шт., Быстрые ноги - {Speed} шт., Умоляющий взгляд - {aPleadingLook} шт.");

                                Eloquence = Eloquence - 1;
                                Console.ReadLine();
                                Console.Clear();

                                Console.WriteLine("Каким-то чудом ваш длинный язык вам помог и вы отделались парочкой словестных\r\nоскарблений на которые вам в принцепе было все равно.\n" +
                                    "После увлекательной беседы пахан покидает вашу сочевалню и вы остаетесь на едине с вашей танковой братвой и продолжаете\n" +
                                    "Пробивать броню, прокачивать пушки и принимать снаряды в башню...");

                                Console.ReadLine();

                                Console.WriteLine("Отыграв еще парочку каточек и офрмив несколько филигранных пробитий вы с чистой совестью и подгоревшей задницей\n" +
                                    "от косяков ваших тимейтов вы отправились спать. \n" +
                                    "На этом день закончился и вы может собой гордится что он прошел славно...");
                                YouWin();
                                break;
                            }

                        case 2:

                            {
                                Console.Clear();
                                Console.WriteLine("В панике вы залетеле под кровать. Сидя там, покрытый с головы до ног мурашками, истекая холодным потом,\n" +
                                    "скрестив пальцы и моля бога вы надеетесь что вас не найдут. Но увы жизнь жестока и несправедлива.\n" +
                                    "Отец вас замечает и за шкирку достает вас из под кровати..." +
                                    "\nДостав вас из под кровати отец офрмляет вам парачку щииикарных хуков за лож, после чего ваша балбешка отлетает.");

                                GameOver();
                                break;
                            }
                    }

                    Console.Clear();
                }
            }
            else if (userInput == 2)
            {
                Console.Clear();
                EmptyPocet();
            }

        }

    }
    static void CollageLocation()
    {
        int userInput;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Наеонец вы попали в ваш любимый колледж в котором в вашем случае много разного досуга");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Чем же вы хотите заняться ?: 1. Пойти на пары\n" +
                          "                             2. Посетить 109\n" +
                          "                             3. Сходить на студсовет");
        userInput = CheckingAvailability(3);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        switch(userInput)
        {
            case 1:
                {
                    
                    Console.WriteLine("Ничего себе, очень не стандартное решение.\n" +
                                      "Видимо у вас есть веская причина туда пойти.\n" +
                                      "Ну это ваш выбор. Тогда вперед.");
                    Console.ReadLine();
                    Console.WriteLine("Поднявшись на пару этажей вверх по дороге в кабинет\n" +
                                      "вам на встречу идет компания самых клевых парней в шараге.\n" +
                                      "Когда-то вы не плохо общалтсь, но времена изменились...\n" +
                                      "Вы приисполнились в своем познании и вам стало не интересно с этими ултраменьшими\n" +
                                      "И вот они протягивают вам руку что бы поздароваться\n");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ваши действия: 1. Пожать руку\n" +
                                      "               2. Сделать вид что вы очень занятый и прибвать шаг\n");
                    userInput = CheckingAvailability(2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    if (userInput == 1)
                    {
                        Console.WriteLine("- Здарова, парни");
                        Console.ReadLine();
                        Console.WriteLine("- Ваван, как ты ?");
                        Console.ReadLine();
                        Console.WriteLine("- Куда направляешься?");
                        Console.ReadLine();
                        Console.WriteLine("- Та на пару иду");
                        Console.ReadLine();
                        Console.WriteLine("- Ого ничего себе, а чего так?");
                        Console.ReadLine();
                        Console.WriteLine("- Та просто");
                        Console.ReadLine();
                        Console.WriteLine("- Ну лан тогда, топай");
                        Console.ReadLine();
                        Console.Clear();
                        WhatsAppMoment();
                    }
                    
                    else if(userInput == 2) 
                    { 
                        Console.Clear();
                        Console.WriteLine("Как настоящая уважающая себя крыса, скукурузив важнкю морду вы прошли мимо");
                        Console.ReadLine();
                        WhatsAppMoment();
                    }
                   
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Ну конечно, лучше этого только студ совет.");
                    Console.ReadLine();
                    Console.WriteLine("Вы подшли к обители фикскиов и прочих людей хоть каким - то образом связанными\n" +
                                      "с программмированием во ВКУиНТе.\n" +
                                      "Дверь вам открывает старый друг Шнур.\n");
                    Console.ReadLine();
                    Console.WriteLine("- Здаров, Ваван. Ты какими судьбами опять здесь?\n ");
                    Console.ReadLine();
                    Console.WriteLine("- Здаров, та как обычно посидеть позалипать.\n ");
                    Console.ReadLine();
                    Console.WriteLine("- Как ты уже ... Ну лан сиди.\n ");
                    Console.ReadLine();
                    Console.WriteLine("- Спасибо!\n ");
                    Console.WriteLine("Пары закончились. Все это время когда шли пары вы капали на мозги Шнуру,\n" +
                                      "но вот настал час шагать домой... ");
                  YouWin();

                    break;
                }
            case 3:
                {

                    Console.WriteLine("Вы пошли в актовый зал.\n" +
                                      "Зайдя туда вы увидели что ваши друзья нефоры уже собрались и ждали только вас\n");
                    Console.ReadLine();
                    Console.WriteLine("- Добрый ден ребята, сегодня у нас на повестке дня ...\n");
                    Console.ReadLine();
                    Console.WriteLine("Дальше рзгорелись крайне увлекательные диалоги в которых вы принимали активное участие.\n" +
                                      "Вы узнали что в колледже будет проходить конкурс 'Мисс и Мистер'\n " +
                                      "в котором вы как настоящий подсос не могли не принять участия\n");
                    Console.ReadLine();
                    Console.WriteLine("Приминев все свои интелектуальные способности и собрав своб бригаду фриков\n " +
                                      "Вы смогли придумать гениальнейший номер и взяли на себя самую сложную и ответсвенную роль\n " +
                                      "Выйти и светануть своей мордой.\n");
                    Console.ReadLine();
                    Console.WriteLine("Спустя время...\n ");
                    Console.ReadLine();
                    Console.WriteLine("Наконец настал день мероприятия.\n" +
                                      "Вы со своими бедолагами показали настоящий класс и выйграли конкурс.\n" +
                                      "Было ли это удачей, хорошей подготовкой, а может вы просто всем подсосали об этом уже никто не узнает...\n");
                    YouWin();

                    break;
                }
        }
    }
    static void LoveStory()
    {
        int userInput;
        Console.Clear();
        Console.WriteLine("Привет малышка, я Вова, я бы хотел с тобой познакомится,\n" +
                          "скажу сразу я не последний человек в этом колледже, за меня здесь все знают что я хорошняк пацан,\n" +
                          "косяков за спиной не имею, а мой язык не то что до Киева доведет... Ладно, давай не будем.\n");
        Console.ReadLine();
        Console.WriteLine("П-п-привет, я-я Альбина, у тебя такие класные шторы, ну давай п-п-познакомимся.\n");
        Console.ReadLine();
        Console.WriteLine("Отлично бейби, ты не пожелеешь! Сколько пар у тебя осталось?\n");
        Console.ReadLine();
        Console.WriteLine("У нас п-пары уже закончились.\n");
        Console.ReadLine();
        Console.WriteLine("Супер! Тогда ты не против прогуляться по прекрасной спартановке?\n");
        Console.ReadLine();
        Console.WriteLine("Давай, а тебе разве не нужно на пару?\n");
        Console.ReadLine();
        Console.WriteLine("Бей, я же сказал что я не последний человек, ничего страшного, пошли.\n");
        Console.ReadLine();
        Console.WriteLine("И вы отправились на прогулочку. Малышка как типичная альтушка оказалась достаточно застенчивой\n" +
                          "и что бы развести ее на разные ништяки вам прийдется постараться... \n");
        Console.ReadLine();
        Console.WriteLine("Вот в пришли в парки и присели на лавочку...\n");
        Console.Clear();
        Console.ReadLine();
        Console.WriteLine(" - Вов, а расскажи о себе. И почему ты решили познакомиться именно со мной?\n");
        Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Что вы скажите?: 1. Правду матку\n" +
                          "                 2. Байки оврага\n");
        userInput = CheckingAvailability(2);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        if (userInput == 1 )
        {
            Console.WriteLine("Малая, я обычный питон програмистер, который любит откосить пары\n" +
                              "тусить в студсовете и клеить 7ми классниц. К сожалениию у меня это плохо получается,\n" +
                              "но поверь малыш, с тобой все по другому. Когда я увидел тебя я сразу понял что ты именно\n" +
                              "та которую я всегда и искал и мне кажется это любовь...\n");
            Console.ReadLine();
            Console.WriteLine("Блин, это правда? Я даже не ожидала такой искренности.\n " +
                              "А ты хороший парень оказывается, ты мне нравишься.\n");
            Console.ReadLine();
            Console.WriteLine("Вне себя от счастья то что вы наконец-то кому-то\n" +
                              "понравились таким какой есть вы решеаете сделать еще один шаг\n");
            Console.ReadLine();
            Console.WriteLine("- Алин, может быть поедем ко мне?");
            Console.ReadLine();
            Console.WriteLine("- Я не против.");
            Console.ReadLine();
            Console.WriteLine("И вы отправились на остановку и стали дожидаться маршрутки.\n" +
                              "Вот она приехала и вы вошли.\n");
            Console.ReadLine();
            Console.WriteLine("- С вас 60 руб за проезд\n");
            CheckMoney(60);

            Console.WriteLine("Вы отправились в путь и спутя 30 минут добрались до дома.\n");
            Console.ReadLine();
            Console.WriteLine("Чем займемся? Может быть кино посмотрим?\n");
            Console.ReadLine();
            Console.WriteLine("А может быть займемся чем нибудь поинтересней? Если ты понимаешт о чем я...\n");
            if (Condoms > 0)
            {
                Console.WriteLine("Ну давай...\n");
                Console.ReadLine();
                Console.WriteLine("CENSORED\n");
                Console.ReadLine();
                Console.WriteLine("Что же было дальше? А это уже не важно." +
                                  "В этот момент вы поняли что есть люди которые вас любят настоящего " +
                                  "И вы прожили этот прекрасно...\n");

                YouWin();
            }
            else
            {
                Console.WriteLine("-Та не, давай лучше кино.\n");
                Console.ReadLine();
                Console.WriteLine("- Ну хорошо.\n");
                Console.ReadLine();
                Console.WriteLine("И вы в обнимку со своей кралей легли смотреть старый романтический фильм.\n" +
                                  "Так вы и уснули...\n");
                YouWin();
            }

        }
        else if (userInput == 2)
        {
            Console.WriteLine("-Малыш, что могу о себе скзать даже не знаю, просто обычно за меня говорят деньги\n" +
                              "ведь я сказачно богат. В своем деле я профе умнее меня разве что Андерс Хейлсберг\n" +
                              "я еще топовый самбист так что в беде ты никогда не окажишься, это наверное все.\n");
            Console.ReadLine();
            Console.WriteLine("- Ммм, понятно ...\n");
            Console.ReadLine();
            Console.WriteLine("- Ты мне не веришь?\n");
            Console.ReadLine();
            Console.WriteLine("- Та просто мой папа знает всех людей которые при деньгах в области\n" +
                              "но твоей фамилии я там не разу не слышла\n");
            Console.ReadLine();
            Console.WriteLine("- Эм та там наверное списки старые\n");
            Console.ReadLine();
            Console.WriteLine("- Ну давай я прям сейчас папепе позвоню и узнаю.\n");
            Console.ReadLine();
            Console.WriteLine("Вы не успели ничего сказть, а она уже набрала отцу\n" +
                              "После двух минут диалога Алины с папой, ваша илюзия разрушилась...\n");
            Console.ReadLine();
            Console.WriteLine("- Зачем ты мне соврал ?\n");
            Console.ReadLine();
            Console.WriteLine("- Хотел тебя впечатли, но я правда...\n");
            Console.ReadLine();
            Console.WriteLine("- Нет, Вов, ты вроде парень не плохой, но я ненавижу лжецов\n " +
                              "так что прощай\n");
            Console.ReadLine();
            Console.WriteLine("И она вас покинула. И вы остались один на этой скамейке.\n" +
                              "Из-за очередного романтического провала вы как настоящий дед инсайд решаете\n" +
                              "Наложить на себя руки...\n");
            GameOver();


        }
    }
    
}