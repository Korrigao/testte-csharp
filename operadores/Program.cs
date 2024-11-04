// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Principais operadores : + adição, - subtração, / divisão, * multiplicação, 
double resultado1 = 12 + 8 + 12 / 4;
Console.WriteLine(resultado1);


double resultado2 = (12 + 8 + 12) / 3;
Console.WriteLine(resultado2);


double resultado3 = (2 + 8) * 2 / 4;
Console.WriteLine(resultado3);


//(!=) =  diferença
//(==) = Igual
bool res = 5==10 / 2;
Console.WriteLine(res);
bool resu = 3!=6;
Console.WriteLine(resu);
//Operadores Lógicos

//AND (&&) lógico = retorna verdadeiro somente se as duas expressões forem verdadeiras
bool a = true;
bool b = false;
Console.WriteLine(a&&b);

//OR (||) Lógico = retorna verdadeiro se ao menos umas das exprossões for verdadeiro
bool pa = true;
bool ga = false;
Console.WriteLine(pa||ga);

//Not Lógico (!) = Inverte o valor de uma expressão. Se é true vira falsa e vice versa
bool pol = true;
Console.WriteLine(!pol);

//Ou exclusivo (^) = So irá retornar como verdadeiro se uma expressões E A outra também for falsa.
bool gap = true;
bool upa = false;
Console.WriteLine(gap^upa);

// Precedencia de operadores lógicos: (!)not logico, (&&)And Lógico, (||)Or lógico e (^)ou exclusivo

bool ui = true;
bool ai = false;
bool ca = false;
bool ressss = !ui||(ai&&ca);
Console.WriteLine(ressss);

bool ku = false;
bool ii = false;
bool ja = false;
bool dab = !ku||ii&&ja;
Console.WriteLine(dab);