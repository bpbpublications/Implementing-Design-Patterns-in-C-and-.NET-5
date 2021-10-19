namespace _6.ChapterSix6._1.OpenClosedPrinciple
{
    interface IUser
    {
        bool Active { get; set; }
        string Email { get; set; }
        string FullName { get; set; }
        IPlatformAccount PlatformAccount { get; set; }
    }
}