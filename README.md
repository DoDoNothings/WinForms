Задание 1
Вывести на экран свое (краткое!!!) резюме с помощью последовательности MessageBox’ов (числом не менее трех). Причем на заголовке последнего должно отобразиться
среднее число символов на странице (общее количество символов в резюме / количество MessageBox’ов).

Задание 2
Написать функцию, которая «угадывает» задуманное пользователем число от 1 до 2000. Для запроса к пользователю использовать
MessageBox. После того, как число отгадано, необходимо вывести количество запросов, потребовавшихся для этого, и предоставить
пользователю возможность сыграть еще раз, не выходя из программы (MessageBox’ы оформляются кнопками и значками соответственно ситуации).

Задание 3
Представьте, что у вас на форме есть прямоугольник, границы которого на 10 пикселей отстоят от границ рабочей области формы. Не-
обходимо создать следующие обработчики:
■■ Обработчик нажатия левой кнопки мыши, который выводит сообщение о том, где находится текущая точка: внутри прямоугольника, снаружи,
на границе прямоугольника.Если при нажатии левой кнопки мыши была нажата кнопка Control (Ctrl), то приложение должно закрываться;
■■ Обработчик нажатия правой кнопки мыши, который выводит в заголовок окна информацию о размере клиентской
(рабочей) области окна в виде: Ширина = x, Высота = y, где x и y – соответствующие параметры вышего окна;
■■ Обработчик перемещения указателя мыши в пределах рабочей области, который должен выводить в заголовок окна
текущие координаты мыши x и y.

Задание 4
Разработать приложение, созданное на основе форме. Пользователь «щелкает» левой кнопкой мыши по форме и,
не отпуская кнопку, ведет по ней мышку, а в момент отпускания кнопки по полученным координатам прямоуголь-
ника (вам, конечно, известно, что двух точек на плоскости достаточно для создания прямоугольника) необходимо со-
здать «статик», который содержит свой порядковый номер (имеется в виду порядок появления на форме).
■■ Минимальный размер «статика» составляет 10х10, при попытке создания элемента меньших размеров пользователь
должен увидеть соответствующее предупреждение.■■ При щелчке правой кнопкой мыши над поверхностью
«статика» в заголовке окна должна появиться информация о его площади и координатах (относительно формы).
В случае, если в точке щелчка находится несколько «статиков», то предпочтение отдается «статику» с наибольшим
порядковым номером■■ При двойном щелчке левой кнопки мыши над поверхностью «статика» он должен исчезнуть с формы. В случае,
если в точке щелчка находится несколько «статиков», то предпочтение отдается «статику» с наименьшим порядко-
вым номером.

Задание 5
Разработать приложение «убегающий статик»:) Суть приложения: на форме расположен статический элемент управления («статик»).
Пользователь пытается подвести курсор мыши к «статику», и, если курсор находиться близко со статиком, элемент управления «убега-
ет». Предусмотреть перемещение «статика» только в пределах формы.

Задание 6
Написать программу, которая по введенной дате определяет день недели. Результат выводить в текстовое поле (желательно по-русски).

Задание 7
Написать программу, вычисляющую сколько осталось времени до указанной даты (дата вводится с клавиатуры в Edit). Предусмот-
реть возможность выдачи результата в годах, месяцах, днях, минутах, секундах (для первых двух вариантов ответ дробный). Для переклю-
чения между вариантами желательно использовать переключатели (RadioButton).
