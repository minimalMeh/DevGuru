﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevGuru.Resources.ru {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ru {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ru() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DevGuru.Resources.ru.ru", typeof(ru).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Клиент — это класс, который содержит существующую бизнес-логику программы..
        /// </summary>
        internal static string Adapter_Step1 {
            get {
                return ResourceManager.GetString("Adapter_Step1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Клиентский интерфейс описывает протокол, через который клиент может работать с другими классами..
        /// </summary>
        internal static string Adapter_Step2 {
            get {
                return ResourceManager.GetString("Adapter_Step2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Сервис — это какой-то полезный класс, обычно сторонний. Клиент не может использовать этот класс напрямую, так как сервис имеет непонятный ему интерфейс..
        /// </summary>
        internal static string Adapter_Step3 {
            get {
                return ResourceManager.GetString("Adapter_Step3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Адаптер — это класс, который может одновременно работать и с клиентом, и с сервисом. Он реализует клиентский интерфейс и содержит ссылку на объект сервиса. Адаптер получает вызовы от клиента через методы клиентского интерфейса, а затем переводит их в вызовы методов обёрнутого объекта в правильном формате..
        /// </summary>
        internal static string Adapter_Step4 {
            get {
                return ResourceManager.GetString("Adapter_Step4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Работая с адаптером через интерфейс, клиент не привязывается к конкретному классу адаптера. Благодаря этому, вы можете добавлять в программу новые виды адаптеров, независимо от клиентского кода. Это может пригодиться, если интерфейс сервиса вдруг изменится, например, после выхода новой версии сторонней библиотеки..
        /// </summary>
        internal static string Adapter_Step5 {
            get {
                return ResourceManager.GetString("Adapter_Step5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Интерфейс строителя объявляет шаги конструирования продуктов, общие для всех видов строителей..
        /// </summary>
        internal static string Builder_Step1 {
            get {
                return ResourceManager.GetString("Builder_Step1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Конкретные строители реализуют строительные шаги, каждый по-своему. Конкретные строители могут производить разнородные объекты, не имеющие общего интерфейса..
        /// </summary>
        internal static string Builder_Step2 {
            get {
                return ResourceManager.GetString("Builder_Step2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Продукт — создаваемый объект. Продукты, сделанные разными строителями, не обязаны иметь общий интерфейс..
        /// </summary>
        internal static string Builder_Step3 {
            get {
                return ResourceManager.GetString("Builder_Step3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Директор определяет порядок вызова строительных шагов для производства той или иной конфигурации продуктов..
        /// </summary>
        internal static string Builder_Step4 {
            get {
                return ResourceManager.GetString("Builder_Step4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Обычно Клиент подаёт в конструктор директора уже готовый объект-строитель, и в дальнейшем данный директор использует только его. Но возможен и другой вариант, когда клиент передаёт строителя через параметр строительного метода директора. В этом случае можно каждый раз применять разных строителей для производства различных представлений объектов..
        /// </summary>
        internal static string Builder_Step5 {
            get {
                return ResourceManager.GetString("Builder_Step5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Компонент определяет общий интерфейс для простых и составных компонентов дерева..
        /// </summary>
        internal static string Compose_Step1 {
            get {
                return ResourceManager.GetString("Compose_Step1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Лист — это простой компонент дерева, не имеющий ответвлений.
        ///
        ///Из-за того, что им некому больше передавать выполнение, классы листьев будут содержать большую часть полезного кода..
        /// </summary>
        internal static string Compose_Step2 {
            get {
                return ResourceManager.GetString("Compose_Step2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Контейнер (или композит) — это составной компонент дерева. Он содержит набор дочерних компонентов, но ничего не знает об их типах. Это могут быть как простые компоненты-листья, так и другие компоненты-контейнеры. Но это не является проблемой, если все дочерние компоненты следуют единому интерфейсу.
        ///
        ///Методы контейнера переадресуют основную работу своим дочерним компонентам, хотя и могут добавлять что-то своё к результату..
        /// </summary>
        internal static string Compose_Step3 {
            get {
                return ResourceManager.GetString("Compose_Step3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Клиент работает с деревом через общий интерфейс компонентов.
        ///
        ///Благодаря этому, клиенту не важно, что перед ним находится — простой или составной компонент дерева..
        /// </summary>
        internal static string Compose_Step4 {
            get {
                return ResourceManager.GetString("Compose_Step4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Фасад предоставляет быстрый доступ к определённой функциональности подсистемы. Он «знает», каким классам нужно переадресовать запрос, и какие данные для этого нужны..
        /// </summary>
        internal static string Facade_Step1 {
            get {
                return ResourceManager.GetString("Facade_Step1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Дополнительный фасад можно ввести, чтобы не «захламлять» единственный фасад разнородной функциональностью. Он может использоваться как клиентом, так и другими фасадами..
        /// </summary>
        internal static string Facade_Step2 {
            get {
                return ResourceManager.GetString("Facade_Step2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Сложная подсистема состоит из множества разнообразных классов. Для того, чтобы заставить их что-то делать, нужно знать подробности устройства подсистемы, порядок инициализации объектов и так далее.
        ///
        ///Классы подсистемы не знают о существовании фасада и работают друг с другом напрямую..
        /// </summary>
        internal static string Facade_Step3 {
            get {
                return ResourceManager.GetString("Facade_Step3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Легковес применяется в программе, имеющей громадное количество одинаковых объектов. Этих объектов должно быть так много, чтобы они не помещались в доступную оперативную память без ухищрений. Паттерн разделяет данные этих объектов на две части — легковесы и контексты..
        /// </summary>
        internal static string Flyweight_Step1 {
            get {
                return ResourceManager.GetString("Flyweight_Step1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Легковес содержит состояние, которое повторялось во множестве первоначальных объектов. Один и тот же легковес можно использовать в связке со множеством контекстов. Состояние, которое хранится здесь, называется внутренним, а то, которое он получает извне — внешним..
        /// </summary>
        internal static string Flyweight_Step2 {
            get {
                return ResourceManager.GetString("Flyweight_Step2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Контекст содержит «внешнюю» часть состояния, уникальную для каждого объекта. Контекст связан с одним из объектов-легковесов, хранящих оставшееся состояние..
        /// </summary>
        internal static string Flyweight_Step3 {
            get {
                return ResourceManager.GetString("Flyweight_Step3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Поведение оригинального объекта чаще всего оставляют в Легковесе, передавая значения контекста через параметры методов. Тем не менее, поведение можно поместить и в контекст, используя легковес как объект данных..
        /// </summary>
        internal static string Flyweight_Step4 {
            get {
                return ResourceManager.GetString("Flyweight_Step4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Клиент вычисляет или хранит контекст, то есть внешнее состояние легковесов. Для клиента легковесы выглядят как шаблонные объекты, которые можно настроить во время использования, передав контекст через параметры..
        /// </summary>
        internal static string Flyweight_Step5 {
            get {
                return ResourceManager.GetString("Flyweight_Step5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Фабрика легковесов управляет созданием и повторным использованием легковесов. Фабрика получает запросы, в которых указано желаемое состояние легковеса. Если легковес с таким состоянием уже создан, фабрика сразу его возвращает, а если нет — создаёт новый объект..
        /// </summary>
        internal static string Flyweight_Step6 {
            get {
                return ResourceManager.GetString("Flyweight_Step6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Контекст хранит ссылку на объект состояния и делегирует ему часть работы, зависящей от состояний. Контекст работает с этим объектом через общий интерфейс состояний. Контекст должен иметь метод для присваивания ему нового объекта-состояния..
        /// </summary>
        internal static string State_Step1 {
            get {
                return ResourceManager.GetString("State_Step1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Состояние описывает общий интерфейс для всех конкретных состояний..
        /// </summary>
        internal static string State_Step2 {
            get {
                return ResourceManager.GetString("State_Step2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Конкретные состояния реализуют поведения, связанные с определённым состоянием контекста. Иногда приходится создавать целые иерархии классов состояний, чтобы обобщить дублирующий код.
        ///
        ///Состояние может иметь обратную ссылку на объект контекста. Через неё не только удобно получать из контекста нужную информацию, но и осуществлять смену его состояния..
        /// </summary>
        internal static string State_Step3 {
            get {
                return ResourceManager.GetString("State_Step3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to И контекст, и объекты конкретных состояний могут решать, когда и какое следующее состояние будет выбрано. Чтобы переключить состояние, нужно подать другой объект-состояние в контекст..
        /// </summary>
        internal static string State_Step4 {
            get {
                return ResourceManager.GetString("State_Step4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Контекст хранит ссылку на объект конкретной стратегии, работая с ним через общий интерфейс стратегий..
        /// </summary>
        internal static string Strategy_Step1 {
            get {
                return ResourceManager.GetString("Strategy_Step1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Стратегия определяет интерфейс, общий для всех вариаций алгоритма. Контекст использует этот интерфейс для вызова алгоритма.
        ///
        ///Для контекста неважно, какая именно вариация алгоритма будет выбрана, так как все они имеют одинаковый интерфейс..
        /// </summary>
        internal static string Strategy_Step2 {
            get {
                return ResourceManager.GetString("Strategy_Step2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Конкретные стратегии реализуют различные вариации алгоритма..
        /// </summary>
        internal static string Strategy_Step3 {
            get {
                return ResourceManager.GetString("Strategy_Step3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Во время выполнения программы контекст получает вызовы от клиента и делегирует их объекту конкретной стратегии..
        /// </summary>
        internal static string Strategy_Step4 {
            get {
                return ResourceManager.GetString("Strategy_Step4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Клиент должен создать объект конкретной стратегии и передать его в конструктор контекста. Кроме этого, клиент должен иметь возможность заменить стратегию на лету, используя сеттер. Благодаря этому, контекст не будет знать о том, какая именно стратегия сейчас выбрана..
        /// </summary>
        internal static string Strategy_Step5 {
            get {
                return ResourceManager.GetString("Strategy_Step5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Абстрактный класс определяет шаги алгоритма и содержит шаблонный метод, состоящий из вызовов этих шагов. Шаги могут быть как абстрактными, так и содержать реализацию по умолчанию..
        /// </summary>
        internal static string TemplateMehod_Step1 {
            get {
                return ResourceManager.GetString("TemplateMehod_Step1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Конкретный класс переопределяет некоторые (или все) шаги алгоритма. Конкретные классы не переопределяют сам шаблонный метод..
        /// </summary>
        internal static string TemplateMethod_Step2 {
            get {
                return ResourceManager.GetString("TemplateMethod_Step2", resourceCulture);
            }
        }
    }
}
