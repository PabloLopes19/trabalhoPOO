class Findev{
    private Interface screen;
    private string userName;
    private string userSlug;
    private string userBio;
    private string company;
    private string job;
    private List<Acc> Data = new List<Acc>();

    public Findev(Interface screen) {
        this.screen = screen;
    }
}