public class Socket {
    public boolean powerIsOn;

    public Socket() {
        powerIsOn = true;
    }

    public void powerOn() {
        powerIsOn = true;
        System.out.println("Power is ON");
    }

    public void powerOff() {
        powerIsOn = false;
        System.out.println("Power is OFF");
    }
}
