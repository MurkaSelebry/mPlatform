﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using mPlatform.Core;

namespace mPlatform.MVVM.ViewModel
{
    class HomeViewModel: ObservableObject
    {
        public RelayCommand MovieViewCommand { get; set; }
        public MovieViewModel MovieVM { get; set; }
        public MainViewModel mainViewModel { get; set; }

        public ObservableCollection<MovieViewModel> Movies { get; set; }
        public MovieViewModel SelectedMovie
        {
            get { return MovieVM; }
            set
            {
                MovieVM = value;
                MovieVM.SetMovie(this);
                OnPropertyChanged("SelectedMovie");
            }
        }
        public HomeViewModel(MainViewModel mv)
        {

            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            Movies = new ObservableCollection<MovieViewModel> {
                new MovieViewModel(new Model.Movie(
                new Model.MovieInfo("Мой домашний крокодил",new DateTime(2022,6,28),"Джош Гордон, Уилл Спек","США","мюзикл, фэнтези, комедия, приключения, семейный".Split(new char[] { ',' }),"Лайл – именно так зовут уникального в своем роде крокодила, который сильно отличается от многочисленных других представителей данного рода пресмыкающихся. " +
                "Ведь он – вовсе не кровожадное существо, а полная противоположность последнего. " +
                "Доброжелательно настроенный в отношении людей, он уже немалое время, как поддерживает свое существование на чердаке одного из пустующих старых домов в Нью-Йорке. Одним из его самых любимых хобби является пение, которым он увлекается еще с малых лет. Таким образом, он – поющий крокодил, который, к тому же, любит модно одеваться." + 
"В один из обычных дней в этот дом переезжает жить семейка Приммов, которые лишь недавно приобрели это жилье. Каковым огромным оказывается их удивление, когда в некий момент ни осознают, что на чердаке обитает самый настоящий крокодил. Изначально эти люди впадают в шок. Н уже спустя короткий период времени ни осознают, что имеют дело с самым добрым во всем мире крокодилом!",
8.4),
                "/Images/crocodile.png",
                projectDirectory+@"\Videos\crocodile.mp4",
                10.0)),
                new MovieViewModel(new Model.Movie(
                new Model.MovieInfo("Корабль в Пусан",new DateTime(2022,7,18),"Ким Хон-сон","Корея Южная","боевик, ужасы, криминал".Split(new char[]{','}),"Под прикрытием перевозки особо опасных преступников с Филиппин в порт Пусана должны доставить секретный груз. Безопасность его транспортировки обеспечивает элитный спецназ. Когда заключенные захватывают судно, пытаясь добраться до ценного груза, оказывается, что на корабле есть сила пострашнее их. Чтобы попасть в Пусан, охранникам и особо опасным преступникам придется пройти через настоящий ад.   ",4.8),
                "/Images/ship.png",
                projectDirectory+"/Videos/ship.mp4",
                4.8)),
                new MovieViewModel(new Model.Movie(
                new Model.MovieInfo("Последняя охота",new DateTime(2022,1,18),"Кристиан Камарго","США","вестерн".Split(new char[]{','}),"1909 год. Умирающий Старый Запад. Карлота и Уилли Бой любят друга друга. Но против их отношений выступает отец возлюбленной. По случайному стечению обстоятельств, выстрелив из пистолета, Уилли Бой непреднамеренно убивает отца Карлоты. Спасаясь от сурового правосудия, они бегут в выжженную солнцем пустыню Мохаве. А местный шериф с помощниками отправляется за ними в погоню...",4.8),
                "/Images/last.png",
                projectDirectory+"Videos/last.mp4",
                2.8)),
                new MovieViewModel(new Model.Movie(
                new Model.MovieInfo("Чёрная Пантера: Ваканда навсегда",new DateTime(2022,3,11),"Ким Хон-сон","Райан Куглер","фантастика, боевик, драма".Split(new char[]{','}),"Африканское государство под названием Ваканда находится на этапе стремительного развития, которое идёт быстрыми темпами. Люди, живущие в этой местности, могут гордиться передовыми технологиями и новшествами инопланетного происхождения. Каждый из них в глубине души рад быть жителем живописной страны и частью сильного народа с удивительной историей. В этих краях сконцентрированы хорошие запасы редких минералов. В Ваканде на протяжении долгого времени ведётся добыча вибраниума.Земли, хранящие в себе настоящее богатство, служат объектом постоянного противоборства. Когда из жизни уходит легендарный правитель, конфликт стремительно набирает обороты и сильно обостряется. Узнав весть о его кончине, многие державы загорелись желанием завладеть Вакандой вместе с её удивительными природными ресурсами. Но для того, чтобы осуществить эту затею, противникам придётся познать силу и мощь королевы Рамонды и её соратников, которые не готовы просто так уступить дорогие сердцу территории. Они настроены решительно и готовы дать мощный отпор. На стороне Ваканды оказывается и Шури – девушка, которая вдохновляет команду, разрабатывая различные устройства, позволяющие достойно показать себя в бою и отразить атаку. ",4.8),
                "/Images/vakanda.png",
                projectDirectory+"Videos/vakanda.mp4",
                4.6)),
                new MovieViewModel(new Model.Movie(
                new Model.MovieInfo("На Западном фронте без перемен",new DateTime(2022,2,14),"Эдвард Бергер","США, Германия","боевик, драма, военный".Split(new char[]{','}),"Под прикрытием перевозки особо опасных преступников с Филиппин в порт Пусана должны доставить секретный груз. Безопасность его транспортировки обеспечивает элитный спецназ. Когда заключенные захватывают судно, пытаясь добраться до ценного груза, оказывается, что на корабле есть сила пострашнее их. Чтобы попасть в Пусан, охранникам и особо опасным преступникам придется пройти через настоящий ад.   ",4.8),
                "/Images/front.png",
                projectDirectory+"Videos/front.mp4",
                10.0)),
                new MovieViewModel(new Model.Movie(
                new Model.MovieInfo("Pokerface",new DateTime(2022,7,18),"Ким Хон-сон","Корея Южная","боевик, ужасы, криминал".Split(new char[]{','}),"Под прикрытием перевозки особо опасных преступников с Филиппин в порт Пусана должны доставить секретный груз. Безопасность его транспортировки обеспечивает элитный спецназ. Когда заключенные захватывают судно, пытаясь добраться до ценного груза, оказывается, что на корабле есть сила пострашнее их. Чтобы попасть в Пусан, охранникам и особо опасным преступникам придется пройти через настоящий ад.   ",4.8),
                "/Images/pokerface.png",
                projectDirectory+"Videos/pokerface.mp4",
                10.0)),
                new MovieViewModel(new Model.Movie(
                new Model.MovieInfo("Черный адам",new DateTime(2022,7,18),"Ким Хон-сон","Корея Южная","боевик, ужасы, криминал".Split(new char[]{','}),"Под прикрытием перевозки особо опасных преступников с Филиппин в порт Пусана должны доставить секретный груз. Безопасность его транспортировки обеспечивает элитный спецназ. Когда заключенные захватывают судно, пытаясь добраться до ценного груза, оказывается, что на корабле есть сила пострашнее их. Чтобы попасть в Пусан, охранникам и особо опасным преступникам придется пройти через настоящий ад.   ",4.8),
                "/Images/black-adam.png",
                projectDirectory+"Videos/black-adam.mp4",
                4.0)),
                };
            mainViewModel = mv;
           




        }
    }
}
