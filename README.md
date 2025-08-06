# UnityDeveloperTestTask-semaGgroZ

Для теста предлагается использовать 2 дерева из папки Configs с демонстрацией двух примеров из ТЗ. Деревья назначаются в поле MissionsRunner'а.  

Краткое описание работы:  
MissionsRunner - это точка входа.  
MissionsTreeConfig содержит ноды и работает по принципу BehaviourTree.  
Ноды делятся на:  
- Mission - нода вызова миссии.  
- Chain - список нод для последовательного вызова.  
- Parallel - список нод для параллельного вызова.

Миссии наследуют MissionBase, LogMission - дефолтная реализация миссии.  

## Проблемы:
- Нет контроля над созданием миссий.
- Изменён интерфейс IMission.  
- Возможно, стоит заменить StartAsync в нодах дерева на Run + NodeState и вызывать их в Update у раннера.  

## Time
- Deadline time: not specified.
- Completion time: 2.5 hours.
