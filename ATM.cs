// ATM.cs
// Represents an automated teller machine.
public class ATM
{

    //TODO: definiciones para las variables autenticacion de usuario, numero de cuenta actual, pantalla
    //teclado, dispensador, slot de deposito, y base de dato
  

   //TODO: representacion del menu de opciones
   private enum MenuOption 
   {
      
   } 

   // TODO: Constructor
   public ATM()
   {
     
   } 

   //Metodo para la corrida inicial de los parametros
   public void Run()
   {
     //TODO: autenticacion de usuario y mostrar el pantalla mensaje de bienvenida
        //realizando además otras acciones como usuario autenticado, mostrando el 
        //numero de cuenta y un mesaje de despedida
         PerformTransactions();
         userAuthenticated = false; 
         currentAccountNumber = 0;
         screen.DisplayMessageLine( "\nThank you! Goodbye!" );
   
   } 

   //TODO: autenticación del usuario en la base de datos, introduciendo los datos de
    //numero de cuenta, pin y accediendo a la base de datos
   
   //TODO: Muestra el menu principal despues de haberse logeado en la base de datos
   private void PerformTransactions()
   {
      
   } 

   //TODO: medoto para mostrar el menu principal
   private int DisplayMainMenu()
   {
      
   }

    //TODO: retorna la transaccion derevida de la clase Transaccion
    private Transaction CreateTransaction(int type)
    {


        return 0;
    }
   
}