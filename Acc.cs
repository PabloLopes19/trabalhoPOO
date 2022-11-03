class Acc {
    private string userName;
    private string userSlug;
    private string userBio;
    private string company;
    private string job;
    public List<string> userProfile = new List<string>();

    public Acc(string username, string userSlug, string bio, string company, string job) {
        this.userName = username;
        this.userSlug = userSlug;
        this.userBio = bio;
        this.company = company;
        this.job = job;

        this.userProfile.Add(username);
        this.userProfile.Add($"@{userSlug}");
        this.userProfile.Add(bio);
        this.userProfile.Add(company);
        this.userProfile.Add(job);
    }
}