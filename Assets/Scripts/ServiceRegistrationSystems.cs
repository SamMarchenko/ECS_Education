using DefaultNamespace;

public class ServiceRegistrationSystems : Feature
{
   public ServiceRegistrationSystems(Contexts contexts, Services.Services services)
   {
       Add(new RegisterInputServiceSystem(contexts, services.Input));
       Add(new RegisterViewServiceSystem(contexts, services.View));
   }
}