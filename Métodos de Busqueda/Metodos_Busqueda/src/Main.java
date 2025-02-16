//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {

        int [] A = {4,7,2,8,3,0,5,8};
        int i, pos = -1;
        int dato = 8;

        for(i=0; i<A.length; i++){
          if(dato == A[i]){
              pos = i;
              System.out.println("El elemento fue encontrado en la posicion "+(+pos+1));
          }
        }
        if(pos == -1){
            System.out.println("El elemento no fue encontrado");
        }
    }
}