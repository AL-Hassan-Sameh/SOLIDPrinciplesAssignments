public class Program {
    public static void main(String[] args) {
        Socket mySocket = new Socket();
        mySocket.powerIsOn = true;
        
        ILightSource myCFL = new CFL();
        myCFL.setSocket(mySocket);
        
        ILightSource myIncandescent = new Incandescent();
        myIncandescent.setSocket(mySocket);
        
        ILightSource myLED = new LED();
        myLED.setSocket(mySocket);
        
        ILightSource[] lightSources = new ILightSource[] { myCFL, myIncandescent, myLED };
        
        for (ILightSource item : lightSources) {
            System.out.println("Light source name:");
            item.printName();
            System.out.println();
            System.out.println("Switching on the light source");
            item.switchOn();
            System.out.println();
            System.out.println("Powering off");
            mySocket.powerOff();
            System.out.println();
            System.out.println("Switching on the light source");
            item.switchOn();
            System.out.println();
            System.out.println("Switching on the light source again");
            item.switchOn();
            System.out.println();
            System.out.println("Switching off the light source");
            item.switchOff();
            System.out.println();
            System.out.println("Powering on again");
            mySocket.powerOn();
            System.out.println();
            System.out.println("Switching on the light source");
            item.switchOn();
            System.out.println();
            System.out.println("Switching on the light source again");
            item.switchOn();
            System.out.println();
            System.out.println("Switching off the light source");
            item.switchOff();
            System.out.println("Switching off the light source again");
            item.switchOff();
            System.out.println("-------------------------------------------");
        }
    }
}
