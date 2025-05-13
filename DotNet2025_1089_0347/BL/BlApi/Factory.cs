using BlImplementation;
namespace BlApi;

public static class Factory
{
    private static IBl? iBl;
    public static IBl Get
    {
        get
        {
            if (iBl == null)
                iBl = new Bl();
            return iBl;
        }
    }

}