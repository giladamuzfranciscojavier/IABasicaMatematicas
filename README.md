# IA Basica Matematicas

## Escena añadida

Añadida la escena IABasicaMatematicas, que consiste en un policía (jugador) y 3 ladrones (npcs). Para el movimiento del jugador se reutiliza el script *VillagerDrive*, mientras que el movimiento automático emplea un script similar a *PigMove*, pero con algunos cambios:

- Los npcs rotan y se mueven en el sentido *opuesto* al jugador, ya que los ladrones deben huir del policía
- La rotación solo se realiza si el policía está cerca.
- Se muestran rayos debug en el visor de escena similares a los de la escena del tanque, mostrando de color verde la visión frontal del ladrón y de color rojo el rango de detección.
- El movimiento y el cálculo de distancia se realizan solamente sobre los ejes *X* y *Z*. Los npcs nunca huyen hacia arriba o hacia abajo y nunca tendrán en cuenta una potencial distancia vertical

Además, el plano está delimitado por paredes invisibles para evitar que los npcs se salgan de la pantalla (no afectan al jugador).