using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatiN.Core;
using WatiN.Core.Native.Chrome;

namespace LaFiesta
{
    class Program
    {
        const string PASSWORD = "lafiesta123";

        #region Names

        static string[] names = new string[] {"Marci", "Casaus","Laurence","Delahanty","Verda","Kolesar","Glenn","Bedoya","Kirk","Kauppi",
            "Demetra","Yaple","Hoa","Drescher","Opal","Matsui","Soon","Armenta","Jermaine","Farabaugh","Arnulfo","Drakes","Tamara",
            "Matranga","Alane","Frawley","Cathern","Alper","Nella","Pledger","Marx","Paulino","Tenisha","Naron","Faith","Vogus","Sid",
            "Moors","Nona","Ansell","Magen","Herrick","Vilma","Kitamura","Kandi","Erick","Elmo","Benfield","Maddie","Levin","Margarite",
            "Craven","Sheree","Zachery","Suzy","Kensey","Caleb","Heffley","Shea","Mcnair","Iraida","Higginson","Hallie","Matsumura","Margherita",
            "Mccallon","Nelida","Basnett","Noella","Condra","Pattie","Park","Sixta","Coppola","Harlan","Page","Harland","Stoker","Brandon","Hollifield",
            "Guillermina","Coan","Daine","Suarez","Georgina","Gottschalk","Ryann","Taft","Corey","Gwinn","Rochell","Laurel","Davis","Cleary","Deb","Monsour",
            "Suzanne","Aitken","Lakendra","Vu","Lorraine","Jackson","Lanette","Bowker","Kerrie","Booth","Tamala","Dugas","Shirlene","Zang","Arica","Gundlach",
            "Samara","Rich","Anton","Schartz","Rossie","Saeger","Hyun","Mccaffery","Pattie","Sanon","Pamella","Wingrove","Nathalie","Verduzco","Colin","Schillinger",
            "Denver","Muhammad","Renita","Tiner","Delois","Brauer","Eddie","Scarberry","Omega","Geisel","Giovanna","Sokoloski","Rosette","Kenyon","Anisa","Cargill",
            "Chadwick","Finn","Debera","Race","Hope","Sweeney","Ena","Mcmakin","Camila","Weinstock","Rosemarie","English","Nathaniel","Henne","Jarrett","Kruger",
            "Jong","Hirano","Cortney","Goff","Rodrigo","Yokley","Milagros","Gargiulo","Genaro","Kessel","Nathanael","Pomerleau","Mitsuko","Kurt","Synthia","Dasilva",
            "Lexie","Vicknair","Ruthann","Martir","Ferne","Mcclean","Altha","Durrett","Judith","Elswick","Francisco","Jain","Asa","Blanks","Daniell","Isaacs","Sudie",
            "Precourt","Twana","Pavelka","Heide","Alfonso","Essie","Piraino","Gino","Moran","Kaylee","Jong","Millicent","Andrepont","Cleopatra","Hosford","Halina",
            "Vanpatten","Oralia","Crenshaw","Lilliam","Harnois","Mel","Bones","Kenya","Beal","Tomoko","Galang","Deane","Keel","Tracie","Bloomquist","Josh","Avilez",
            "Fernando","Barajas","Reginald","Ebron","Elina","Flora","Teddy","Mcclaskey","Luann","Palen","Chante","Lenart","Tama","Sigler","Celestina","Eyre","Bobby",
            "Hubley","Aleen","Hamamoto","Carey","Bogner","Holley","Mccrady","Virginia","Redfearn","Gayle","Lauritzen","Corey","Shutt","Frances","Maben","Olivia",
            "Scheuerman","Armandina","Hallock","Renita","Pepper","Ronda","Norcross","King","Colin","Iliana","Mclaurin","Russel","Tousant","Myriam","Branscome","Dylan",
            "Breeze","Arlen","Pinnell","Gregoria","Eno","Teresa","Lalli","Iola","Mock","Neta","Antoine","Debbi","Bobadilla","Joye","Haris","Luciana","Doll","Ramon",
            "Hennings","Monte","Contos","Kina","Rueckert","Rebbeca","Hoss","Reta","Erlandson","Mable","Rawls","Hyon","Ivey","Providencia","Skoglund","Remedios","Bouldin",
            "Jodie","Korb","Merna","Freed","Detra","Sitzes","Sydney","Renna","Eboni","Myricks","Georgine","Hagopian","Shira","Montano","Gwyneth","Ledezma","Josette",
            "Trotter","Myrle","Stmarie","Anette","Silver","Margo","Reay","Dell","Taggart","Valentina","Driggers","Kemberly","Sommerville","Launa","Guthrie","Rosendo",
            "Slovak","Yer","Litwin","Madie","Baum","Nia","Wallner","Yi","Griego","Wilma","Mccullar","Terina","Purser","Fallon","Mcdorman","Hobert","Magdaleno","Jone",
            "Sanders","Loni","Hetrick","Marita","Blades","Chrystal","Towler","Olen","Camillo","Moises","Roehr","Classie","Iorio","Gillian","Lasso","Bronwyn","Cryer",
            "Tristan","Garrow","Shirl","Rolston","Shawnee","Vankleeck","Carlo","Adkins","Iraida","Brazzell","Salina","Daughtridge","Na","Graham","Dee","Ackerman",
            "Elza","Carruth","Estell","Hemond","Margeret","Kocher","Ernie","Poppe","Ike","Angeles","Efren","Warwick","Max","Rigsby","Ashley","Barbara","Brenton",
            "Swanigan","Henry","Plaza","Tomas","Crotty","Randolph","Gatchell","Jason","Macedo","Alonso","Ogletree","Cole","Purtell","Bo","Castagna","Isaac",
            "Mance","Dominick","Fritch","Carson","Gossman","Levi","Pabon","Alec","Benitez","Ronald","Summerfield","Rosendo","Eddins","Devon","Mailloux","Tanner",
            "Washburn","Hai","Cornell","Lionel","Huhn","Wesley","Rudder","Alvin","Hendriks","Edwin","Trundy","Maximo","Giesler","Val","Heiner","Ross","Jefferys",
            "Brent","Sugg","Andy","Kollman","Raul","Wheeling","Erick","Pelc","Danial","Kellum","Rudolf","Saucedo","Cordell","Vezina","Winford","Husband","Keven",
            "Corpuz","Darryl","Vandam","Jerrod","Rodden","Wayne","Dodgen","Augustine","Kao","Rayford","Bruemmer","Rueben","Weitzman","Lloyd","Brassard","Dennis",
            "Ikerd","Otha","Resendes","Rashad","Corzine","Mohammed","Bosley"};


        #endregion

        [STAThread]
        static void Main(string[] args)
        {
            // Pra não correr o risco do e-mail 
            // já existir para alguma pessoa com o mesmo nome e sobrenome
            Console.WriteLine("Digite um conjunto de caracteres para garantir a unicidade dos e-mails (não utilize muitos caracteres):");
            string emailsUniqueKey = Console.ReadLine();

            Console.Clear();

            if (emailsUniqueKey.Length > 5)
            {
                Console.WriteLine("Qual a parte do \"não utilize muitos caracteres\" você não entendeu?\n\n");
                emailsUniqueKey = emailsUniqueKey.Substring(0, 5);
            }

            int length;
            Console.WriteLine("Digite quantas vezes você gostaria de executar a postagem (default 20, para mandar mensagem digite 1):");
            if (!Int32.TryParse(Console.ReadLine(), out length))
            {
                Console.Clear();
                Console.WriteLine("Vou deixar 20 e fingir que você sabe o que é um inteiro.");
                length = 20;
            }
            else
            {
                Console.Clear();
            }

            // Para que as mensagens não fiquem repetitivas, elas devem ser digitadas e adicionadas uma a uma
            string mensagem = string.Empty;
            if (length == 1)
            {
                Console.WriteLine("Digite sua mensagem de carinho:");
                mensagem = Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("\n\n ------------- Iniciando -------------");

            Console.WriteLine("\n\n Espero que você tenha Internet Explorer instalado... ");

            using (var browser = new IE("https://foursquare.com/"))
            {
                for (int seed = 0; seed < length; seed++)
                {
                    // Abrindo formulário de cadastro
                    browser.Link(Find.ById("signupButton")).Click();
                    browser.Div(Find.ById("signupButtonMenu")).Link(Find.ByClass("emailSignup")).Click();

                    // Preenchendo o formulário
                    Random rnd = new Random();

                    string firstName = names[rnd.Next(501)];
                    string lastName = names[rnd.Next(501)];
                    string email = String.Format("{0}_{1}_{3}{2}@mailinator.com", firstName.ToLowerInvariant(), lastName.ToLowerInvariant(), seed, emailsUniqueKey);
                    int day = rnd.Next(1, 29); // Até 28, pra não ter problema com fevereiro
                    int month = rnd.Next(1, 13);

                    browser.TextField(Find.ById("inputEmail")).Value = email;
                    browser.TextField(Find.ById("inputPassword")).Value = PASSWORD;
                    browser.TextField(Find.ById("inputFirstName")).Value = firstName;
                    browser.TextField(Find.ById("inputLastName")).Value = lastName;
                    browser.TextField(Find.ById("inputBirthDate")).Value = day < 10 ? "0" + day : day.ToString();
                    browser.TextField(Find.ById("inputBirthMonth")).Value = month < 10 ? "0" + month : month.ToString();
                    browser.TextField(Find.ById("inputBirthYear")).Value = rnd.Next(1950, 2000).ToString();

                    // Clica em Sing Up
                    browser.Button(Find.ById("signupButton")).Click();

                    // Clica em Skip
                    browser.Button(Find.ById("finishedTastesButton")).Click();

                    // Clica em Finished
                    browser.Button(Find.ById("closeButton")).Click();

                    // Preenche o campo de pesquisa
                    browser.TextField(Find.ById("headerBarSearch")).Value = "La Fiesta";

                    // Vai para o perfil do la fiesta
                    browser.GoTo("https://foursquare.com/v/la-fiesta/536c3ea0498e38181e296a5f");

                    // Clica em dislike - por não conseguir achar a classe certa, temos que fazer foreach
                    var actionBar = browser.Div(Find.ById("actionBar"));
                    foreach (var div in actionBar.Divs)
                    {
                        if (div.ClassName.Contains("dislike"))
                        {
                            div.Click();
                            break;
                        }
                    }

                    // Adiciona mensagem
                    if (length == 1)
                    {
                        // Escreve o texto
                        foreach (var div in browser.Div(Find.ByClass("addTipBlock")).Divs)
                        {
                            if (div.ClassName.Contains("addTipArea"))
                            {
                                foreach (var item in div.Elements)
                                {
                                    if (item.ClassName.Contains("formStyle"))
                                    {
                                        ((TextField)item).Value = mensagem;
                                        break;
                                    }
                                }
                                break;
                            }
                        }

                        // Clica em publicar
                        foreach (var button in browser.Div(Find.ByClass("buttonArea")).Buttons)
                        {
                            if (button.ClassName.Contains("greenButton"))
                            {
                                button.Click();
                                break;
                            }
                        }
                    }

                    // Faz logoff
                    browser.Link(Find.ById("logoutLink")).Click();
                    Console.WriteLine("Execução finalizada ~ " + (seed + 1));
                }

                Console.WriteLine("\n\n ------------- Finalizado -------------");
            }
        }
    }
}
