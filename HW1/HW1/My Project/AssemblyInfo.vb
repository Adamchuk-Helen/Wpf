﻿Imports System
Imports System.Globalization
Imports System.Reflection
Imports System.Resources
Imports System.Runtime.InteropServices
Imports System.Windows

' Общие сведения об этой сборке предоставляются следующим набором
' набора атрибутов. Измените значения этих атрибутов, чтобы изменить сведения,
' связанные со сборкой.

' Проверьте значения атрибутов сборки

<Assembly: AssemblyTitle("HW1")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("HW1")>
<Assembly: AssemblyCopyright("Copyright ©  2021")>
<Assembly: AssemblyTrademark("")>
<Assembly: ComVisible(false)>

'Чтобы начать создание локализуемых приложений, задайте
'<UICulture>ТребуемоеЗначение</UICulture> в файле .vbproj
'внутри <PropertyGroup>.  Например, если используется английский США
'в исходных файлах установите значение <UICulture> равным "en-US".  Затем снимите комментарий
'с атрибута NeutralResourceLanguage (ниже).  Замените "en-US" в расположенной ниже
'строке значением, соответствующим параметру UICulture в файле проекта.

'<Assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)>


'Атрибут ThemeInfo указывает расположение словарей ресурсов для конкретной темы и словарей общих ресурсов.
'1-й параметр: расположение словарей ресурсов для конкретной темы
'(используется, если ресурс не найден на странице,
' или в словарях ресурсов приложения)

'2-й параметр: расположение словаря общих ресурсов
'(используется, если ресурс не найден на странице,
'в приложении и в словарях ресурсов для конкретной темы)
<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)>



'Следующий идентификатор GUID представляет идентификатор typelib, если этот проект доступен через COM
<Assembly: Guid("c20805e3-59c5-4b92-8a57-ff7d2c017c9c")>

' Сведения о версии сборки состоят из следующих четырех значений:
'
'      Основной номер версии
'      Дополнительный номер версии
'   Номер сборки
'      Редакция
'
' Можно задать все значения или принять номера сборки и редакции по умолчанию 
' используя "*", как показано ниже:
' <Assembly: AssemblyVersion("1.0.*")>

<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
