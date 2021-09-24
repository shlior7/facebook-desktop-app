namespace BasicFacebookFeatures
{
    public interface IHandler
    {
        void setNextHandler(IHandler i_NextHandler);

        void Handle(Document i_Text);
    }
}