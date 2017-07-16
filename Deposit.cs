// Deposit.cs
// Represents a deposit ATM transaction.
public class Deposit : Transaction
{
    //TODO: variables para implementar cantidad de deposito, teclado y lugar de deposito


   //TODO: constante que representa los botones sin funcionalidad
   private const int CANCELED = 0;

	//TODO: constructor con cinco parametros numero de cuenta de usuario, pantalla, base de datos
	//teclado y lugar de deposito, con un constructor base 
	 public Deposit( int userAccountNumber, Screen atmScreen, 
      BankDatabase atmBankDatabase, Keypad atmKeypad, 
      DepositSlot atmDepositSlot )
      : base( userAccountNumber, atmScreen, atmBankDatabase )
   {
      //TODO: inicializamos el teclado y lugar de deposito
     
   }

    //TODO: metodo sobreecritura para la cantidad depositada e implementacion de los 
    //procesos que se tienen que realizar mostrando en pantalla el resultado de los depositos
    //y guardandolos en la base de datos.
    public override void Execute()
    {

        //TODO: verificar si el deposito es exitoso, si lo es muestra el deposito
    }
} 