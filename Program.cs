using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone meuIphone14 = new Iphone("819 21222", "Iphone 14 pro Max", " 223333", "1TB");
Nokia meuNokia = new Nokia("819 21222", "Iphone 14 pro Max", " 223333", "2TB");


meuIphone14.Ligar();
meuIphone14.ReceberLigacao();
meuIphone14.InstalarAplicativo("Sportzy");


meuNokia.Ligar();
meuNokia.ReceberLigacao();
meuNokia.InstalarAplicativo("YouTube");

