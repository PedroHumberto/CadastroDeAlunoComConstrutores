using System;


namespace CadastroDeAluno {
    class Student {

        public string Name;
        public double Note1, Note2, Note3;
        
        
        //Construtor, é adicionado as informações para depois dar os valores a elas
        public Student(string name, double note1, double note2, double note3) {
            Name = name;
            Note1 = note1;
            Note2 = note2;
            Note3 = note3;
        }

        public double FinalResult() {
            return Note1 + Note2 + Note3;
        }

        public bool Aproved() {
            if (FinalResult() >= 60.0) {
                return true;
            }
            else {
                return false;
            }
        }

        public double RestNote() {
            if (Aproved()) {
                return 0.0;
            }
            else {
                return 60.0 - FinalResult();
            }
        }

    }

}
