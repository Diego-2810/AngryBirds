~~~ mermaid
classDiagram

class IslaPajaro {
  -List~Pajaro~ Pajaros
  +FuerzaTotal() int
  +PajarosFuertes() List~Pajaro~
  +EnojarATodos()
}

class Pajaro {
  -int ira
  +CalcularFuerza() int
  +Enojarse()
}

class Red {
  -int vecesEnojado
  +CalcularFuerza() int
}

class Bomb {
  -int topeFuerza
  +CalcularFuerza() int
}

class Chuck {
  -int velocidad
  +CalcularFuerza() int
  +Enojarse()
}

class Terence {
  -int vecesEnojado
  -int multiplicador
  +CalcularFuerza() int
}

class Matilda {
  -List~Huevo~ huevos
  +CalcularFuerza() int
  +Enojarse()
}

class Huevo {
  -int peso
  +Fuerza() int
}

Pajaro <|-- Red
Pajaro <|-- Bomb
Pajaro <|-- Chuck
Pajaro <|-- Terence
Pajaro <|-- Matilda

Matilda --> Huevo
IslaPajaro --> Pajaro