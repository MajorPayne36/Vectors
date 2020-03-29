using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_K.Models
{
    public class ProjectContext : DbContext
    {
        public DbSet<Reg> Regs { get; set; }

        public DbSet<History> Histories { get; set; }

        public DbSet<Test> Tests { get; set; }

        public ProjectContext()
        {
            //Database.EnsureDeleted(); //не трогать
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TestDb;Trusted_Connection=True;");
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //добавление вопросов в бд
            modelBuilder.Entity<Test>().HasData(
            #region Вопросы...
                new Test[]
                {
                new Test { Id_Test=1, Question="Какие основные операции над векторами можно проводить?",
                    Answer_1="а) сложение, вычитание, умножение", 
                    Answer_2="б) сложение, умножение, деление",
                    Answer_3="в) умножение, деление, вычитание",
                    Answer_4=null,
                    Correct_answer="а) сложение, вычитание, умножение",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=2, Question="Коллинеарные векторы – это …",
                    Answer_1="а) векторы, которые лежат на одной прямой или на параллельных прямых",
                    Answer_2="б) векторы, стрелки которых направлены в одинаковом направлении",
                    Answer_3="в) векторы, лежащие на одной прямой",
                    Answer_4=null,
                    Correct_answer="а) векторы, которые лежат на одной прямой или на параллельных прямых",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=3, Question="Вектор, длина которого равна 1, называется …",
                    Answer_1="а) коллинеарным",
                    Answer_2="б) единичным",
                    Answer_3="в) нулевым",
                    Answer_4=null,
                    Correct_answer="б) единичным",
                    Quanity_ofponts=0.05},

                /*------------формула-----------------------*/
                new Test { Id_Test=4, Question="Выберите правильный ответ ",
                    Answer_1="а) формула умножения векторов",
                    Answer_2="б) формула угла между векторами",
                    Answer_3="в) формула скалярного произведения векторов",
                    Answer_4=null,
                    Correct_answer="в) формула скалярного произведения векторов",
                    Quanity_ofponts=0.05},
                /*------------формула-----------------------*/


                new Test { Id_Test=5, Question="Какое высказывание является лишним при определении двух равных векторов?",
                    Answer_1="а) Направлены в одну и ту же сторону",
                    Answer_2="б) Параллельны",
                    Answer_3="в) Имеют равные длины",
                    Answer_4="г) Векторы являются неколлинеарными",
                    Correct_answer="г) Векторы являются неколлинеарными",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=6, Question="Векторы называются коллинеарными, если",
                    Answer_1="а) Их сумма равна нулю",
                    Answer_2="б) Они расположены на одной или параллельных прямых",
                    Answer_3="в) Они служат диагоналями параллелограмма",
                    Answer_4="г) Они перпендикулярны",
                    Correct_answer="б) Они расположены на одной или параллельных прямых",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=7, Question="Ортом называется",
                    Answer_1="а) Вектор единичной длины, направление которого совпадает с направлением оси",
                    Answer_2="б) Проекция любого вектора на ось",
                    Answer_3="в) Длина векторного произведения векторов",
                    Answer_4="г) Длина скалярного произведения векторов",
                    Correct_answer="а) Вектор единичной длины, направление которого совпадает с направлением оси",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=8, Question="Два вектора называются ортогональными, если",
                    Answer_1="а) Их длины равны",
                    Answer_2="б) Они расположены на одной прямой",
                    Answer_3="в) Их скалярное произведение равно нулю",
                    Answer_4="г) Для их координат не определена операция умножения",
                    Correct_answer="в) Их скалярное произведение равно нулю",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=9, Question="Какое высказывание не относится к линейной зависимости векторов?",
                    Answer_1="а) Условие - коллинеарность двух векторов",
                    Answer_2="б) Линейная комбинация равна нулю и хотя бы один из коэффициентов линейной комбинации отличен от нуля",
                    Answer_3="в) Условие – компланарность трёх векторов",
                    Answer_4="г) Сумма векторов равна единичному орту",
                    Correct_answer="г) Сумма векторов равна единичному орту",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=10, Question="Три вектора называются упорядоченной тройкой, если:",
                    Answer_1="а) их длины равны между собой и равны единице",
                    Answer_2="б) указано, какой из этих векторов является первым, какой - вторым и какой – третьим",
                    Answer_3="в) их координаты пропорциональны",
                    Answer_4="г) треугольник, построенный на этих векторах, является равнобедренным",
                    Correct_answer="б) указано, какой из этих векторов является первым, какой - вторым и какой – третьим",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=11, Question="Понятие правой и левой тройки теряет смысл для:",
                    Answer_1="а) Векторов, являющихся компланарными",
                    Answer_2="б) Векторов, равных по длине",
                    Answer_3="в) Ортогональных вектров",
                    Answer_4="г) Векторов, длины которых пропорциональны",
                    Correct_answer="а) Векторов, являющихся компланарными",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=12, Question="Площадь треугольника, построенного на приведённых к общему началу двух векторах, равна:",
                    Answer_1="а) Длине векторного произведения этих векторов",
                    Answer_2="б) Половине длины векторного произведения этих векторов",
                    Answer_3="в) Длине векторного произведения этих векторов, умноженной ",
                    Answer_4="г) Разности длины векторного произведения этих векторов и суммы их длин",
                    Correct_answer="б) Половине длины векторного произведения этих векторов",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=13, Question="Какое высказывание не относится к понятию компланарности трёх векторов?",
                    Answer_1="а) Они лежат в одной плоскости",
                    Answer_2="б) Их смешанное произведение равно нулю",
                    Answer_3="в) Равен нулю определитель, строками которого служат координаты этих векторов",
                    Answer_4="г) Их сумма даёт нулевой вектор",
                    Correct_answer="г) Их сумма даёт нулевой вектор",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=14, Question="Среди двух неколлинеарных векторов не может быть:",
                    Answer_1="а) Вектора, длина которого равна длине орта",
                    Answer_2="б) Нулевого вектора",
                    Answer_3="в) Единичного вектора",
                    Answer_4="г) Вектора, длина которого равна длине другого вектора, умноженного на некоторое число",
                    Correct_answer="б) Нулевого вектора",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=15, Question="Какое утверждение верное?",
                    Answer_1="а) Любые два сонаправленных вектора коллинеарны",
                    Answer_2="б) Любые два коллинеарных вектора протовоположно направлены",
                    Answer_3="в) Любые два коллинеарных вектора протовоположно направлены",
                    Answer_4=null,
                    Correct_answer="а) Любые два сонаправленных вектора коллинеарны",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=16, Question="Какое утверждение неверное?",
                    Answer_1="а) Если длины векторов равны, то и векторы равны",
                    Answer_2="б) Если векторы равны, то их длины равны",
                    Answer_3="в) Длины противоположных векторов равны",
                    Answer_4=null,
                    Correct_answer="а) Если длины векторов равны, то и векторы равны",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=17, Question="Если начало и конец вектора совпадают, то такой вектор называется",
                    Answer_1="а) единичным",
                    Answer_2="б) нет верного ответа",
                    Answer_3="в) нулевым",
                    Answer_4="г) ортом",
                    Correct_answer="в) нулевым",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=18, Question="Как называются три (и более) вектора, которые лежат в одной плоскости или в параллельных плоскостях?",
                    Answer_1="а) параллельными",
                    Answer_2="б) компланарными",
                    Answer_3="в) нет верного ответа",
                    Answer_4="г) коллинеарными",
                    Correct_answer="б) компланарными",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=19, Question="Геометрическое представление суммы векторов, имеющих общее начало, называется правилом",
                    Answer_1="а) параллелепипеда",
                    Answer_2="б) параллелограмма",
                    Answer_3="в) треугольника",
                    Answer_4="г) нет верного ответа",
                    Correct_answer="б) параллелограмма",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=20, Question="Проекции вектора на оси координат называются",
                    Answer_1="а) нет верного ответа",
                    Answer_2="б) направляющими косинусами вектора",
                    Answer_3="в) координатами вектора",
                    Answer_4="г) проекциями вектора",
                    Correct_answer="в) координатами вектора",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=21, Question="Направляющие косинусы единичного вектора равны его",
                    Answer_1="а) нет верного ответа",
                    Answer_2="б) координатам",
                    Answer_3="в) координатам по модулю",
                    Answer_4="г) координатам в квадрате",
                    Correct_answer="б) координатам",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=22, Question="Сумма квадратов направляющих косинусов равна",
                    Answer_1="а) единице",
                    Answer_2="б) тройке",
                    Answer_3="в) двойке",
                    Answer_4="г) нет верного ответа",
                    Correct_answer="а) единице",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=23, Question="Число, равное произведению длин двух ненулевых векторов на косинус угла между ними называется",
                    Answer_1="а) смешанным произведением",
                    Answer_2="б) нет верного ответа",
                    Answer_3="в) скалярным произведением",
                    Answer_4="г) векторным произведением",
                    Correct_answer="в) скалярным произведением",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=24, Question="Если векторы перпендикулярны, то их скалярное произведение равно",
                    Answer_1="а) нулю",
                    Answer_2="б) единице",
                    Answer_3="в) двойке",
                    Answer_4="г) нет верного ответа",
                    Correct_answer="а) нулю",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=25, Question="Площадь параллелограмма, построенного на двух ненулевых векторах, можно найти с помощью",
                    Answer_1="а) векторного произведения",
                    Answer_2="б) смешанного произведения",
                    Answer_3="в) скалярного произведения",
                    Answer_4="г) нет верного ответа",
                    Correct_answer="а) векторного произведения",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=26, Question="Объем параллелепипеда, построенного на трех ненулевых векторах, можно найти с помощью",
                    Answer_1="а) нет верного ответа",
                    Answer_2="б) скалярного произведения",
                    Answer_3="в) векторного произведения",
                    Answer_4="г) смешанного произведения",
                    Correct_answer="г) смешанного произведения",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=27, Question="Если любая точка плоскости является вектором, то как она называется?",
                    Answer_1="а) точечный вектор",
                    Answer_2="б) нулевой вектор",
                    Answer_3="в) модульный вектор",
                    Answer_4="г) равный вектор",
                    Correct_answer="б) нулевой вектор",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=30, Question="Как называются векторы, если они сонаправлены и их длины равны?",
                    Answer_1="а) сонаправленными",
                    Answer_2="б) коллинеарными",
                    Answer_3="в) противоположнонапраленными",
                    Answer_4="г) равными",
                    Correct_answer="г) равными",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=29, Question="Как называются векторы, если они лежат либо на одной прямой, либо на на параллельных прямых?",
                    Answer_1="а) сонаправленными",
                    Answer_2="б) коллинеарными",
                    Answer_3="в) противоположнонапраленными",
                    Answer_4="г) равными",
                    Correct_answer="б) коллинеарными",
                    Quanity_ofponts=0.05},

                new Test { Id_Test=28, Question="Как называется отрезок, для которого указано, какая из его граничных точек считается началом, а какая – концом?",
                    Answer_1="а) вектор",
                    Answer_2="б) прямая",
                    Answer_3="в) луч",
                    Answer_4="г) модуль",
                    Correct_answer="а) вектор",
                    Quanity_ofponts=0.05},

                /*---------------------Задачи---------------------------*/

                new Test { Id_Test=31, Question="Найти сумму двух векторов a = {-8; 2} и b = {8; 7}.",
                    Answer_1="а) (0;9)",
                    Answer_2="б) (16; -5)",
                    Answer_3="в) (0; -5)",
                    Answer_4=null,
                    Correct_answer="а) (0;9)",
                    Quanity_ofponts=0.1},

                new Test { Id_Test=32, Question="Найти сумму двух векторов a = {-17; 5} и b = {3; -2}.",
                    Answer_1="а) (-14; 7)",
                    Answer_2="б) (-21; 7)",
                    Answer_3="в) (-14; 3)",
                    Answer_4=null,
                    Correct_answer="в) (-14; 3)",
                    Quanity_ofponts=0.1},

                new Test { Id_Test=33, Question="Найти разность двух векторов a = {7; 8} и b = {0; 19}",
                    Answer_1="а) (0; 28)",
                    Answer_2="б) (7; -11)",
                    Answer_3="в) (7; 11)",
                    Answer_4=null,
                    Correct_answer="б) (7; -11)",
                    Quanity_ofponts=0.1},

                new Test { Id_Test=34, Question="Найти разность двух векторов a = {0; 5} и b = {17; -2}.",
                    Answer_1="а) (-17; 7)",
                    Answer_2="б) (-17; -7)",
                    Answer_3="в) (17; -7)",
                    Answer_4=null,
                    Correct_answer="а) (-17; 7)",
                    Quanity_ofponts=0.1},

                new Test { Id_Test=35, Question="Найти скалярное произведение векторов a = {3; -1} и b = {-2; 7} ",
                    Answer_1="а) 13",
                    Answer_2="б) -13",
                    Answer_3="в) 11",
                    Answer_4=null,
                    Correct_answer="б) -13",
                    Quanity_ofponts=0.1},

                new Test { Id_Test=36, Question="Найти скалярное произведение векторов a = {6; 7; 10} и b = {8; 5; 9}",
                    Answer_1="а) (13; -26; -23)",
                    Answer_2="б) (11; 25; -26)",
                    Answer_3="в) (13; 26; -26)",
                    Answer_4=null,
                    Correct_answer="в) (13; 26; -26)",
                    Quanity_ofponts=0.1},

                new Test { Id_Test=37, Question="Найти скалярное произведение векторов a = {2; 1; -3} и b = {0; -1; 1}",
                    Answer_1="а) (2, -2, 2)",
                    Answer_2="б) (-2, -2, -2)",
                    Answer_3="в) (-2, 0, 2)",
                    Answer_4=null,
                    Correct_answer="б) (-2, -2, -2)",
                    Quanity_ofponts=0.1},

                new Test { Id_Test=38, Question="Вычислить скалярное произведение векторов   и   , если их длины соответственно равны 2 и 3, а угол между ними 60°.",
                    Answer_1="а) 3",
                    Answer_2="б) 2",
                    Answer_3="в) 4",
                    Answer_4=null,
                    Correct_answer="а) 3",
                    Quanity_ofponts=0.1},

                new Test { Id_Test=39, Question="Найти угол между векторами a = {1; 3} и b = {2; 1}.",
                    Answer_1="а) 15",
                    Answer_2="б) 30",
                    Answer_3="в) 45",
                    Answer_4=null,
                    Correct_answer="в) 45",
                    Quanity_ofponts=0.1},

                new Test { Id_Test=40, Question="Найти угол между векторами a = {1;  3} и b = {1; 0}",
                    Answer_1="а) 90",
                    Answer_2="б) 60",
                    Answer_3="в) 45",
                    Answer_4=null,
                    Correct_answer="б) 60",
                    Quanity_ofponts=0.1},

                new Test { Id_Test=41, Question="Известно, что скалярное произведение двух векторов (a; b) = 2, а их длины |a| = 2, |b| = 2 . Найти угол между векторами  a и b.",
                    Answer_1="а) 45",
                    Answer_2="б) 60",
                    Answer_3="в) 90",
                    Answer_4=null,
                    Correct_answer="б) 60",
                    Quanity_ofponts=0.1},

                new Test { Id_Test=42, Question="Найдите длину векторного произведения векторов а и b, если известно, что длина вектора а равна 4, а длина вектора b равна 5, угол между векторами равен π/6.",
                    Answer_1="а) 10",
                    Answer_2="б) 20",
                    Answer_3="в) 15",
                    Answer_4=null,
                    Correct_answer="а) 10",
                    Quanity_ofponts=0.1},

                new Test { Id_Test=43, Question="Найдите длину векторного произведения векторов а и b, если известно, что длина вектора а равна 4, а длина вектора b равна 5, угол между векторами равен π/6.",
                    Answer_1="а) 10",
                    Answer_2="б) 20",
                    Answer_3="в) 15",
                    Answer_4=null,
                    Correct_answer="а) 10",
                    Quanity_ofponts=0.1},

                new Test { Id_Test=44, Question="В прямоугольной декартовой системе координат заданы координаты трех точек A(1,0,1), B(0,2,3), C(1,4,2). Найдите какой-нибудь вектор, перпендикулярный векторам АВ и АС одновременно.",
                    Answer_1="а) (6; 1; 4)",
                    Answer_2="б) (3; 1; -4)",
                    Answer_3="в) (-6; 1; -4)",
                    Answer_4=null,
                    Correct_answer="в) (-6; 1; -4)",
                    Quanity_ofponts=0.1},

                new Test { Id_Test=45, Question="Найдите смешанное произведение векторов: а = {5, -1, 3}, b = {2, 4, 2}, c = {7, -6, 2}.",
                    Answer_1="а) -30",
                    Answer_2="б) 14",
                    Answer_3="в) -34",
                    Answer_4=null,
                    Correct_answer="а) -30",
                    Quanity_ofponts=0.1}
                });
            #endregion

            //немного легкой эротики
            modelBuilder.Entity<Test>().HasKey(t => t.Id_Test);
            modelBuilder.Entity<History>().HasKey(t => t.Id_result);
            modelBuilder.Entity<Reg>().HasKey(t => t.Id_student);
            // modelBuilder.Entity<History>().HasNoKey();
            // modelBuilder.Entity<Reg>().HasNoKey();
            // modelBuilder.Entity<Test>().HasNoKey();

            //modelBuilder.Entity<History>().HasOne(t => t.Id_student) //
            //.WithOne(t => t.)
            //.HasForeignKey(p => p.CompanyInfoKey);
        }
    }
}