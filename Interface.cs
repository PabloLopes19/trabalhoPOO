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

    public void systemScreen() {}

    private void yBorder(int li, int lf, int ci, int cf) {}
    
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

    public void clearArea(int ci, int li, int cf, int lf) {}

    public void xLine(int line, int ci, int cf) {}

    public void yLine(int col, int li, int lf) {}

    public void center(int lin, int ci, int cf, string msg) {}

    public void nameScreen() {}

    public void homeScreen() {}

    public void button(int lin, int col, string msg, ConsoleColor color) {}

    public void buildMenu(int col, int lin){}

    public string inputField(int col, int lin, string question){
        return question;
    }
}