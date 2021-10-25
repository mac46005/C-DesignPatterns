namespace PracticeDesignPatterns.ClassLib.Classes{
    public sealed class HelloWorldSingleton{
        private static HelloWorldSingleton _instance = null;
        private HelloWorldSingleton(){}
        public static HelloWorldSingleton SingleInstance{
            get{
                if(_instance == null){
                    _instance = new HelloWorldSingleton();
                }
                return _instance;
            }
        }
        
        public string HelloThere(string name){
            return $"Hello {name}";
        }
    }
}