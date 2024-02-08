public abstract class LightSource implements ILightSource {
    protected String type;
    protected String dutchName;
    public Socket socket;
    public boolean isSwitchedON;

    public LightSource(String type, String dutchName) {
        this.type = type;
        this.dutchName = dutchName;
    }

    public void setSocket(Socket socket) {
        this.socket = socket;
    }

    public void printName() {
        System.out.println("I am a/an " + type + " light, known as \"" + dutchName + "\" in Dutch.");
    }

    public void switchOn() {
        if (!socket.powerIsOn) {
            isSwitchedON = false;
            System.out.println("The light cannot be turned on due to power outage");
            return;
        }
        if (isSwitchedON) {
            System.out.println("Light is already on.");
            return;
        }
        isSwitchedON = true;
        System.out.println(type + " is now on.");
    }

    public void switchOff() {
        if (!socket.powerIsOn) {
            System.out.println("Power is already off.");
            return;
        }
        if (!isSwitchedON) {
            System.out.println("Light is already off.");
            return;
        }
        isSwitchedON = false;
        System.out.println(type + " is now off.");
    }
}
