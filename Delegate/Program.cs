
var objeto = new ClassFuncion();

MiDelegate f = objeto.func1;

Console.WriteLine($"El resultado es {f(10, 100)}");

MiDelegate e = objeto.func2;
Console.WriteLine($"El  resultado de la multiplicasion es {e(50, 2)}");


var objeto2 = new MiClase();
MiDelegate t = objeto2.InstaciaDeMetodo;
Console.WriteLine($"El resultado es: {t(30, 60)}");


var react = new Prueba();
Otromas y = react.runrun;
Console.WriteLine($"El resultado es :P: {y(10, 20, 8)}");


var angular = new Namshi();
Textos u = angular.edad;
Console.WriteLine($"La sume es {u(10, 5)}");

public delegate string MiDelegate(int arg1, int arg2);

public delegate string Otromas(int arg1, int arg2, int arg3);

public delegate string Textos(int a, int b);

