using System;

class MainClass {
  public static void Main (string[] args) {
    
    Navio arcelo = new Navio(50, 100, "Arcelo", "JLG");
    Navio cst    = new Navio(40, 150, "Cst", "DINI");

    Console.WriteLine();
    if(cst.MaiorCapacidade(arcelo)){
        Console.WriteLine("O Navio Da " + cst.GetNome() + " do Fabricante: " + " tem Maior Capacidade!");
    }else{
      Console.WriteLine("O Navio Da " + arcelo.GetNome() + " tem Maior Capacidade!");
    }

    // Console.WriteLine();
    // //Metodo Embarcar
    // arcelo.Embarcar(10);
    // Console.WriteLine("Capacidade Atual: " + arcelo.GetCargaAtual());
    
    
  }
}