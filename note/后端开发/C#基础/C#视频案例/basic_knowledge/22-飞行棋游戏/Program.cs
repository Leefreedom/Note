using System;

namespace _22_飞行棋游戏
{
    class Program
    {
        public static int[] Maps = new int[100];//存储地图的数组

        public static int[] PlayerPors = new int[2];//存储玩家位置：玩家A==索引0，玩家B==索引1
        public static string[] PlayerName = new string[2];//存储玩家姓名：玩家A==索引0，玩家B==索引1
        public static bool[] Flags = new bool[2];//是否暂停
        static void Main(string[] args)
        {
            GameHead();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            #region 请输入玩家姓名
            Console.WriteLine("请输入玩家A的姓名");
            PlayerName[0] = Console.ReadLine();
            while (PlayerName[0] == "")
            {
                Console.WriteLine("玩家姓名不能为空，请重新输入");
                PlayerName[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名");
            PlayerName[1] = Console.ReadLine();
            while (PlayerName[1] == "" || PlayerName[0] == PlayerName[1])
            {
                if (PlayerName[1] == "")
                {
                    Console.WriteLine("玩家姓名不能为空，请重新输入");
                    PlayerName[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家A和玩家B的姓名不能相同，请重新输入");
                    PlayerName[1] = Console.ReadLine();
                }

            }
            #endregion
            Console.Clear();
            GameHead();
            Console.WriteLine("对战开始.....");
            Console.WriteLine("{0}的士兵用A表示", PlayerName[0]);
            Console.WriteLine("{0}的士兵用B表示", PlayerName[1]);
            InitiaMap();
            DrawMap();
            while (PlayerPors[0] < 99 && PlayerPors[1] < 99)
            {
                if (Flags[0] == false)
                {
                    PlayGame(0);//A 第一次玩的时候踩到了暂停
                }
                else
                {
                    Flags[0] = false;
                }
                if (PlayerPors[0] >= 99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}", PlayerName[0], PlayerName[1]);
                    break;
                }
                if (Flags[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    Flags[1] = false;
                }
                if (PlayerPors[1] >= 99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}", PlayerName[1], PlayerName[0]);
                    break;
                }
            }
            //int finsh = PlayerPors[0] >= 99 ? 0 : 1;
            //PlayerPors[finsh] = 100;
            //Console.WriteLine("游戏结束，玩家{0}获得胜利", PlayerName[finsh]);
            Win();
            Console.ReadKey(true);
        }

        /// <summary>
        /// 画游戏的开头部分
        /// </summary>
        public static void GameHead()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******0326版飞行棋*******");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**************************");
        }

        /// <summary>
        /// 初始化地图
        /// </summary>
        public static void InitiaMap()
        {
            //0表示普通，显示给用户的是□
            //1表示幸运转盘，显示给用户的是◎
            //2表示地雷，显示给用户的是☆
            //3表示暂停，显示给用户的是▲
            //4表示时空隧道，显示给用户的是卍

            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };
            for (int i = 0; i < luckyturn.Length; i++)
            {
                Maps[luckyturn[i]] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
            for (int i = 0; i < landMine.Length; i++)
            {
                Maps[landMine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Maps[timeTunnel[i]] = 4;
            }

        }

        /// <summary>
        /// 画地图
        /// </summary>
        public static void DrawMap()
        {
            Console.WriteLine("图例:幸运转盘:◎ \t 地雷:☆ \t 暂停:▲ \t 时空隧道:卍");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            #region 第一行
            for (int i = 0; i <= 29; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            Console.WriteLine();//换行
            #region 第一竖行
            for (int i = 30; i <= 34; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine(DrawStringMap(i));
            }
            #endregion
            #region 第二行
            for (int i = 64; i >= 35; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            Console.WriteLine();//换行
            #region 第二竖行
            for (int i = 65; i <= 69; i++)
            {
                Console.WriteLine(DrawStringMap(i));
            }
            #endregion

            #region 第三行
            for (int i = 70; i < 100; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            Console.WriteLine();//换行
        }

        /// <summary>
        /// 得到对应的地图字符
        /// </summary>
        /// <param name="i">Maps数组中的地图字符索引</param>
        /// <returns>对应的地图字符</returns>
        public static string DrawStringMap(int i)
        {
            string str = "";
            if (PlayerPors[0] == PlayerPors[1] && PlayerPors[1] == i)
            {
                //Console.Write("<>");
                str = "<>";
            }
            else if (PlayerPors[0] == i)
            {
                //Console.Write("Ａ");
                str = "Ａ";
            }
            else if (PlayerPors[1] == i)
            {
                //Console.Write("Ｂ");
                str = "Ｂ";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0: Console.ForegroundColor = ConsoleColor.DarkYellow; str = "□"; break;//Console.Write("□");  
                    case 1: Console.ForegroundColor = ConsoleColor.Red; str = "◎"; break;//Console.Write("◎"); 
                    case 2: Console.ForegroundColor = ConsoleColor.Green; str = "☆"; break; //Console.Write("☆"); 
                    case 3: Console.ForegroundColor = ConsoleColor.Blue; str = "▲"; break;//Console.Write("▲"); 
                    case 4: Console.ForegroundColor = ConsoleColor.DarkGray; str = "卍"; break;//Console.Write("卍"); 
                }
            }
            return str;
        }

        /// <summary>
        /// 玩游戏
        /// </summary>
        /// <param name="person">玩家索引</param>
        public static void PlayGame(int person)
        {
            int otherPerson = person == 0 ? 1 : 0;
            Random r = new Random();
            Console.WriteLine("玩家{0}按任意键摇骰子", PlayerName[person]);
            Console.ReadKey(true);
            int rNumber = r.Next(1, 7);
            Console.WriteLine("玩家{0}掷出了{1}", PlayerName[person], rNumber);
            PlayerPors[person] += rNumber;
            ChangePos();
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}按任意键行动", PlayerName[person]);
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}行动完了", PlayerName[person]);
            Console.ReadKey(true);
            //玩家A踩到玩家B
            if (PlayerPors[person] == PlayerPors[otherPerson])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1}，玩家{2}退6格。", PlayerName[person], PlayerName[otherPerson], PlayerName[otherPerson]);
                PlayerPors[otherPerson] -= 6;
                ChangePos();
                Console.ReadKey(true);
            }
            //玩家踩到了特殊道具
            else
            {
                switch (Maps[PlayerPors[person]])
                {
                    //踩到方块什么事都没有
                    case 0: Console.WriteLine("踩到方块"); break;
                    //踩到幸运轮盘，1---交换位置，2---轰炸对方
                    case 1:
                        {
                            Console.WriteLine("踩到幸运轮盘，1---交换位置，2---轰炸对方");
                            string input = Console.ReadLine();
                            while (true)
                            {
                                if (input == "1")
                                {
                                    Console.WriteLine("玩家{0}和玩家{1}交换了位置", PlayerName[person], PlayerName[otherPerson]);
                                    int temp = PlayerPors[person];
                                    PlayerPors[person] = PlayerPors[otherPerson];
                                    PlayerPors[otherPerson] = temp;
                                    ChangePos();
                                    Console.ReadKey(true);
                                    break;
                                }
                                else if (input == "2")
                                {
                                    Console.WriteLine("玩家{0}轰炸了玩家{1},玩家{1}退6格", PlayerName[person], PlayerName[otherPerson], PlayerName[otherPerson]);
                                    PlayerPors[otherPerson] -= 6;
                                    ChangePos();
                                    Console.ReadKey(true);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("踩到幸运轮盘，1---交换位置，2---轰炸对方");
                                    input = Console.ReadLine();
                                }
                            }
                            break;
                        }

                    //踩到地雷，退6格
                    case 2: Console.WriteLine("玩家{0}踩到了地雷，退6格", PlayerName[person]); PlayerPors[person] -= 6; ChangePos(); Console.ReadKey(true); break;
                    //踩到暂停，暂停一回合
                    case 3: Console.WriteLine("玩家{0}踩到了暂停，暂停一回合", PlayerName[person]); Flags[person] = true; Console.ReadKey(true); break;
                    //踩到时空隧道，进10格
                    case 4: Console.WriteLine("玩家{0}踩到了时空隧道，进10格", PlayerName[person]); PlayerPors[person] += 10; ChangePos(); Console.ReadKey(true); break;
                }
            }
            Console.Clear();
            DrawMap();
        }

        /// <summary>
        /// 修改位置超出范围调整
        /// </summary>
        public static void ChangePos()
        {
            if (PlayerPors[0] <= 0)
            {
                PlayerPors[0] = 0;
            }
            if (PlayerPors[0] >= 99)
            {
                PlayerPors[0] = 99;
            }
            if (PlayerPors[1] <= 0)
            {
                PlayerPors[1] = 0;
            }
            if (PlayerPors[1] >= 99)
            {
                PlayerPors[1] = 99;
            }
        }

        public static void Win()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                          ◆                      ");
            Console.WriteLine("                    ■                  ◆               ■        ■");
            Console.WriteLine("      ■■■■  ■  ■                ◆■         ■    ■        ■");
            Console.WriteLine("      ■    ■  ■  ■              ◆  ■         ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■       ■■■■■■■   ■    ■        ■");
            Console.WriteLine("      ■■■■ ■   ■                ●■●       ■    ■        ■");
            Console.WriteLine("      ■    ■      ■               ● ■ ●      ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■         ●  ■  ●     ■    ■        ■");
            Console.WriteLine("      ■■■■      ■             ●   ■   ■    ■    ■        ■");
            Console.WriteLine("      ■    ■      ■            ■    ■         ■    ■        ■");
            Console.WriteLine("      ■    ■      ■                  ■               ■        ■ ");
            Console.WriteLine("     ■     ■      ■                  ■           ●  ■          ");
            Console.WriteLine("    ■    ■■ ■■■■■■             ■              ●         ●");
            Console.ResetColor();
        }
    }
}
