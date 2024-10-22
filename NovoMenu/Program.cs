using System;
using System.Collections.Generic;
using static System.Console;
namespace aula_2_desen
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Clear();
                int opc;
                janela(0, 0, 79, 24, 8, 9, 'd');
                janela(31, 7, 51, 12, 5, 12, 's');


                SetCursorPosition(32, 8); Write("[1] conta letras");
                SetCursorPosition(32, 9); Write("[2] Zenit Polar");
                SetCursorPosition(32, 10); Write("[3] letreiro ");
                SetCursorPosition(32, 11); Write("[4] desliza letras");
                SetCursorPosition(32, 12); Write("[5] corrige nomes");
                SetCursorPosition(32, 13); Write("[6] fim");

                SetCursorPosition(30, 22);
                Write("Digite sua opção: ");
                opc = int.Parse(ReadLine());


               

                    switch (opc)
                    {
                        case 1:
                            contaletras();
                            break;
                        case 2:
                            Zenit_Polar();
                            break;
                        case 3:
                            // letreiro();
                            break;
                        case 4:
                            //   desliza letras();
                            break;
                        case 5:
                            contaletras();
                            break;
                        case 6:
                        SetCursorPosition(30, 22);
                            Console.WriteLine("     ...Saindo...        ");
                            Console.ReadKey();
                        Environment.Exit(10);
                        break;
                        default:
                            break;

                    }
            } while (true);
            

           // ReadKey();


        }       //fecha o main() 


        static void contaletras()
        {

            string vfrase = "teste", sair;

            for (int i = 0; i < vfrase.Length; i++)
            {
                Clear();
                Console.WriteLine("escreva uma palavra e eu contarei quantos caracteres há nela "); ;
                Console.Write("escreva aqui -->  ");
                string str = Console.ReadLine();

                int totalCharacter = 0, totalLetterChar = 0, totalDigitChar = 0, totalSpecialChar = 0;

                char[] strArray = str.ToCharArray();
                foreach (var item in strArray)
                {
                    if (char.IsDigit(item))
                        totalDigitChar++;
                    if (char.IsLetter(item))
                        totalLetterChar++;
                    if (!char.IsLetterOrDigit(item))
                        totalSpecialChar++;
                    totalCharacter++;
                }

                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("palavra escrita : " + str);
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("caracteres totais : " + totalCharacter);
                Console.WriteLine("total de letras : " + totalLetterChar);
                Console.WriteLine("total de numeros colocados : " + totalDigitChar);
                Console.WriteLine("total de caracteres especiais : " + totalSpecialChar);
                Console.WriteLine("--------------------------------------------------------");
                Console.ReadKey();

                Write("\n continuar? Y/N   ");
                sair = ReadLine();
                if (sair.ToLower() == "n")
                {
                    return;
                }

                switch (sair.ToLower())


                {
                    case "y":
                        contaletras();
                        break;

                    case "n":
                        return;

                }


            }

        }

        static void Zenit_Polar()
        {
            Clear();
            string vfrase, vfrasefinal = "", vletra;
            int vTam;
            

            Write("digite a frase: ");
            vfrase = ReadLine();



            vTam = vfrase.Length;
            vfrasefinal = "";
            for (int i = 0; i < vTam; i++)
            {
                vletra = vfrase.Substring(i, 1);
                switch (vletra.ToLower())
                {
                    case "z":
                        vfrasefinal += "p";
                        break;
                    case "e":
                        vfrasefinal += "o";
                        break;
                    case "n":
                        vfrasefinal += "l";
                        break;
                    case "i":
                        vfrasefinal += "a";
                        break;
                    case "t":
                        vfrasefinal += "r";
                        break;
                    case "p":
                        vfrasefinal += "z";
                        break;
                    case "o":
                        vfrasefinal += "e";
                        break;
                    case "l":
                        vfrasefinal += "n";
                        break;
                    case "a":
                        vfrasefinal += "i";
                        break;
                    case "r":
                        vfrasefinal += "t";
                        break;
                    default:
                        vfrasefinal += vletra;
                        break;

                }
                //aqui voce desenvolve a verificaçao
                //da letra extraida em relaçao a
                //chave ZENIT POLAR


            }


            Write("A frase criptografada é \n" + vfrasefinal );
           
            Write("\n continuar? Y/N   ");
            

            vletra = ReadLine();
            if (vletra.ToLower()=="n")
            {
                return;
            }
            
            switch (vletra.ToLower())

            
            {
                case "y":
                    Zenit_Polar();
                    break;

                case "n":
                    return;
                  
            }
           // while (Console.ReadKey().Key == ConsoleKey.Y) ;
            //case "y";




        }
    
        static void janela(int c1, int l1, int c2, int l2, int corL, int corF, char borda)
        {
            // 	║ ->  186 -> linha vertical          (lv)
            //	╗ ->  187 -> canto superior direito  (csd)
            //	╝ ->  188 -> canto inferior direito   (cid)
            //	╚ ->  200 -> canto inferior esquerdo   (cie)
            //	╔ ->  201 -> canto superior esquerdo    (cse)
            //	═ ->  205 -> linha horizontal             (lh)

            char lv = ' ', csd = ' ', cid = ' ', cie = ' ', cse = ' ', lh = ' ';
            switch (borda)
            {
                case 'd':
                    lv = '║';
                    csd = '╗';
                    cid = '╝';
                    cie = '╚';
                    cse = '╔';
                    lh = '═';
                    break;
                default:
                    break;

            }

            ForegroundColor = (ConsoleColor)corL;
            ForegroundColor = (ConsoleColor)corF;
            for (int x = l1; x < l2; x++)
            {
                SetCursorPosition(c1, x); Write(lv);
                SetCursorPosition(c2, x); Write(lv);
            }

            SetCursorPosition(c1, l1); Write(new string(lh, c2 - c1));
            SetCursorPosition(c1, l2); Write(new string(lh, c2 - c1));
            // acertando os vertices
            SetCursorPosition(c1, l1); Write(cse);
            SetCursorPosition(c2, l1); Write(csd);
            SetCursorPosition(c1, l2); Write(cie);
            SetCursorPosition(c2, l2); Write(cid);
            for (int x = c1; x < l1; x++)
            {
                SetCursorPosition(31, x);
                Write(new string(' ', 19));

                //enchendo a janela
                //    for (int x = l1 + 1; x++ )
                //{

                //}



            }


        }






    }
}
