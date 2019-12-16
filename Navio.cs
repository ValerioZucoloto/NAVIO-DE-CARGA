 using System;

class Navio{
  private double carga_atual;
  private double carga_maxima;
  private string nome;
  private string fabricante;

public Navio(){
  carga_atual = 0;
  carga_maxima = 0;
  nome = "Não informado!";
  fabricante = "Não inforado!";
}

public Navio(double carga_atual, double carga_maxima, string nome, string fabricante){
  this.carga_atual = carga_atual;
  this.carga_maxima = carga_maxima;
  this.nome = nome;
  this.fabricante = fabricante;
}

//Get Set
public string GetFabricante(){
  return fabricante;
}

public string GetNome(){
  return nome;
}

public double GetCargaAtual(){
  return carga_atual;
}

public double SetCargaAtual(){
  return carga_atual;
}

public double GetCargaMaxima(){
  return carga_maxima;
}

public double SetCargaMaxima(){
  return carga_maxima;
}

public bool MaiorCapacidade(Navio outro){
  if(carga_maxima > outro.carga_maxima){
      return true;
  }else{
    return false;
  }
}

public void Embarcar(double qtdCarga){
  if(qtdCarga < carga_maxima){
      carga_atual = carga_atual - qtdCarga;
      Console.WriteLine("Embarque Efetuado!");
  }
}

}

