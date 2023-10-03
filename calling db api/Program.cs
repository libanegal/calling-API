using calling_db_api;
using calling_db_api.Controllers;
using calling_db_api.Interfaces;
using Microsoft.Extensions.DependencyInjection;


var service = new ServiceCollection();

service.AddTransient<IGetMembers, GetFamilymembers>();
service.AddScoped<IGetaFamily, GetaFamily>();
service.AddTransient<IGetMember, GetMember>();

var serviceProvider = service.BuildServiceProvider();

var getFamilyMembers =  serviceProvider.GetRequiredService<IGetMembers>();
var getFamily = serviceProvider.GetRequiredService<IGetaFamily>();
var getMember = serviceProvider.GetRequiredService<IGetMember>();

var familyOrch = new FamilyOrchestrator(getFamilyMembers,getFamily,getMember);
await familyOrch.FamilyMembersOrchestor();