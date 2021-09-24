namespace BasicFacebookFeatures
{
    public interface IHandler
    {
        void SetNextHandler(IHandler i_NextHandler);

        void Handle(Document i_Text);
    }
}