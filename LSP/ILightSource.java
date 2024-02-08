// ILightSource.java
public interface ILightSource {
    void printName();
    void switchOn();
    void switchOff();
    void setSocket(Socket socket); // Added setSocket method to set the socket for the light source
}
