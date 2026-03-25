~~~ mermaid
classDiagram


class IslaCerdito {
  -List~Obstaculo~ obstaculos
  +RecibirAtaque(List~Pajaro~ Pajaros)
  +SinObstaculos() bool
}

class Obstaculo {
  +Resistencia() int
}

class ParedVidrio {
  -int ancho
  +Resistencia() int
}

class ParedMadera {
  -int ancho
  +Resistencia() int
}

class ParedPiedra {
  -int ancho
  +Resistencia() int
}

class CerditoObrero {
  +Resistencia() int
}

class CerditoCasco {
  -int resistenciaCasco
  +Resistencia() int
}

class CerditoEscudo {
  -int resistenciaEscudo
  +Resistencia() int
}

Obstaculo <|-- ParedVidrio
Obstaculo <|-- ParedMadera
Obstaculo <|-- ParedPiedra
Obstaculo <|-- CerditoObrero
Obstaculo <|-- CerditoCasco
Obstaculo <|-- CerditoEscudo

IslaCerdito --> Obstaculo