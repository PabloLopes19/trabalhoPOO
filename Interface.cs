class Interface {
    private ConsoleColor textColor, bgColor;

    private string[] caractere = {"═","║","╔","╚","╗","╝","╟","╢","╤","╧"};

    public Interface(
        ConsoleColor txt = ConsoleColor.White,
        ConsoleColor bg = ConsoleColor.Black
    ) {
        this.textColor = txt;
        this.bgColor = bg;
        this.configInterface();
    }

    public void configInterface() {
        Console.ForegroundColor = this.textColor;
        Console.BackgroundColor = this.bgColor;
        Console.Clear();
    }

    public void systemScreen() {
        this.frame(0, 0, 88, Console.WindowHeight - 1, ConsoleColor.DarkBlue);
        this.yLine(21, 0, Console.WindowHeight - 1);
        this.xLine(8, 21, 88);
        this.center(1, 24, 24, "FinDev C#");
        this.buildMenu(2, 6);
    }

    private void yBorder(int li, int lf, int ci, int cf) {
        int y;

        for(y = ci; y <= cf; y++){
            Console.SetCursorPosition(y, li);
            Console.Write(caractere[0]);

            Console.SetCursorPosition(y, lf);
            Console.Write(caractere[0]);
        }
    }
    
    public void frame(int ci, int li, int cf, int lf, ConsoleColor color) {
        int y, x;

        Console.ForegroundColor = color;
        Console.BackgroundColor = ConsoleColor.Black;

        this.clearArea(ci, li, cf, lf);
        this.yBorder(li, lf, ci, cf);

        for(x = li; x <= lf; x++) {
            Console.SetCursorPosition(ci, x);
            Console.Write(caractere[0]);

            Console.SetCursorPosition(cf, x);
            Console.Write(caractere[1]);
        }

        Console.SetCursorPosition(ci, li); Console.Write(caractere[2]);
        Console.SetCursorPosition(ci, lf); Console.Write(caractere[3]);
        Console.SetCursorPosition(cf, li); Console.Write(caractere[4]);
        Console.SetCursorPosition(cf, lf); Console.Write(caractere[5]);
    }

    public void clearArea(int ci, int li, int cf, int lf) {
        int y, x;

        for (y = ci; y <= cf; y++){
            for (x = li; x <= lf; x++){
                Console.SetCursorPosition(y, x);
                Console.Write(" ");
            }
        }
    }

    public void xLine(int line, int ci, int cf) {
        int y;

        Console.ForegroundColor = ConsoleColor.DarkBlue;

        for(y = ci; y <= cf; y++) {
            Console.SetCursorPosition(y, line);
            Console.Write(caractere[0]);
        }

        Console.SetCursorPosition(ci, line);
        Console.Write(caractere[6]);

        Console.SetCursorPosition(cf, line);
        Console.Write(caractere[7]);
    }

    public void yLine(int col, int li, int lf) {
        int x;

        Console.ForegroundColor = ConsoleColor.DarkBlue;

        for (x = li; x < lf; x++){
            Console.SetCursorPosition(col, x);
            Console.Write(caractere[1]);
        }

        Console.SetCursorPosition(col, li);
        Console.Write(caractere[8]);

        Console.SetCursorPosition(col, lf);
        Console.Write(caractere[9]);
    }

    public void center(int lin, int ci, int cf, string msg) {
        int y;

        Console.ForegroundColor = ConsoleColor.White;

        y = ci+((cf - ci) / 2);

        Console.SetCursorPosition(y, lin);
        Console.Write(msg);
    }

    public void telaLogin(){
        this.frame(0, 0, 88, Console.WindowHeight-1,ConsoleColor.DarkBlue);
        //janela de login
        this.frame(20,6,70,25,ConsoleColor.DarkBlue);
        this.xLine(10,20,70);
        this.center(8,17,70,"Login");

        //inputs
        Console.SetCursorPosition(23,11);
        Console.Write("Insira o nome de Usuário");
        this.frame(23,12,67,14,ConsoleColor.DarkBlue);

        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(23,15);
        Console.Write("Insira sua Senha");
        this.frame(23,16,67,18,ConsoleColor.DarkBlue);

        //botoes
        this.button(20,23,"1 - Criar Conta",ConsoleColor.DarkBlue);
        this.button(20,49, "2 - Fazer Login",ConsoleColor.DarkBlue);
    }

    public void nameScreen() {}

    public void homeScreen() {}

    public void button(int lin, int col, string msg, ConsoleColor color) {
        this.frame(col, lin, col + msg. Length + 3, lin + 2, color);

        Console.SetCursorPosition(col + 2,lin + 1);
        Console.Write(msg);
    }

    public void buildMenu(int col, int lin){}

    public string inputField(int col, int lin, string question){
        return question;
    }
}