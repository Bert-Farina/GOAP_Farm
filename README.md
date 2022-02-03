# GOAP_Farm
 Simulación de una granja con IA siguiendo un algoritmo GOAP.

## Agentes

Los agentes que componen esta granja son 4 animales (Vaca, cerdo, oveja y gallina) y un granjero.

## Acciones

Los animales tendrán 5 acciones:
* Wander
* GoEat
* GoDrink
* Sleep
* Poop (No en la gallina)

El granjero tendrá 6 acciones:
* CleanPoop
* GoPickFood
* FillFood
* GoToLake
* FillWater
* Rest

Los scripts se pueden encontrar en la carpeta Assets/GOAP/Actions y Assets/GOAP/Agents

## Aspectos a Destacar

### Wander

Se ha programado un comportamiento de Wander usando el target del GOAP y limitando su movimiento al interior del corral.

### Noche

En una de las funciones periódicas programadas dentro del granjero se apaga y enciende la Directional Light de la escena, haciendo que parezca que ha anochecido. Los animales comprobaran una variable del mundo que les dirá cuando es de noche para irse a descansar a su respectivo granero.

### NavMesh

Solo la gallina podrá entrar al granero pequeño, siendo demasiado pequeño para el resto de agentes, configurando un area del navmesh a la que solo puede acceder la gallina.

## Video de ejemplo

https://www.youtube.com/watch?v=rjETboEhwiA
