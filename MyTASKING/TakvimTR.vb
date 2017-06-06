Imports System.Text
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraScheduler.Localization
Imports DevExpress.XtraBars.Localization



Public Class TakvimTR
    Inherits SchedulerLocalizer
    Public Overrides ReadOnly Property Language() As String
        Get
            Return "Turkish"
        End Get
    End Property
    Public Overrides Function GetLocalizedString(id As SchedulerStringId) As String
        Select Case id
            Case SchedulerStringId.Abbr_Day
                Return "Gün"
            Case SchedulerStringId.Abbr_Days
                Return "Gün"
            Case SchedulerStringId.Abbr_DaysShort
                Return "Gün"
            Case SchedulerStringId.Abbr_Hour
                Return "Saat"
            Case SchedulerStringId.Abbr_Hours
                Return "Saat"
            Case SchedulerStringId.Abbr_HoursShort
                Return "Saat"
            Case SchedulerStringId.Abbr_Minutes
                Return "Dakika"
            Case SchedulerStringId.Abbr_MinutesShort1
                Return "Dak"
            Case SchedulerStringId.Abbr_MinutesShort2
                Return "Dk"
            Case SchedulerStringId.Abbr_Month
                Return "Ay"
            Case SchedulerStringId.Abbr_Months
                Return "Ay"
            Case SchedulerStringId.Abbr_Week
                Return "Hafta"
            Case SchedulerStringId.Abbr_Weeks
                Return "Hafta"
            Case SchedulerStringId.Abbr_WeeksShort
                Return "Hf"
            Case SchedulerStringId.Abbr_Year
                Return "Yıl"
            Case SchedulerStringId.Abbr_Years
                Return "Yıl"
            Case SchedulerStringId.Appointment_EndContinueText
                Return "Son / Devam"
            Case SchedulerStringId.Appointment_StartContinueText
                Return "Başla / Devam"
            Case SchedulerStringId.AppointmentLabel_Anniversary
                Return "Yıldönümü"
            Case SchedulerStringId.AppointmentLabel_Birthday
                Return "Doğum günü"
            Case SchedulerStringId.AppointmentLabel_Business
                Return "İş"
            Case SchedulerStringId.AppointmentLabel_Important
                Return "Önemli"
            Case SchedulerStringId.AppointmentLabel_MustAttend
                Return "İlgilenmek gerekir"
            Case SchedulerStringId.AppointmentLabel_NeedsPreparation
                Return "Hazırlık gerekir"
            Case SchedulerStringId.AppointmentLabel_None
                Return "Yok"
            Case SchedulerStringId.AppointmentLabel_Personal
                Return "Kişisel"
            Case SchedulerStringId.AppointmentLabel_PhoneCall
                Return "Telefon görüşmesi"
            Case SchedulerStringId.AppointmentLabel_TravelRequired
                Return "Seyahat gerektirir"
            Case SchedulerStringId.AppointmentLabel_Vacation
                Return "Tatil"
            Case SchedulerStringId.Caption_10Minutes
                Return "10 dakika"
            Case SchedulerStringId.Caption_15Minutes
                Return "15 dakika"
            Case SchedulerStringId.Caption_20Minutes
                Return "20 dakika"
            Case SchedulerStringId.Caption_30Minutes
                Return "30 dakika"
            Case SchedulerStringId.Caption_5Minutes
                Return "5 dakika"
            Case SchedulerStringId.Caption_60Minutes
                Return "60 dakika"
            Case SchedulerStringId.Caption_6Minutes
                Return "6 dakika"
            Case SchedulerStringId.Caption_AllDay
                Return "Tam gün"
            Case SchedulerStringId.Caption_AllResources
                Return "Kaynaklar"
            Case SchedulerStringId.Caption_Appointment
                Return "Not"
            Case SchedulerStringId.Caption_AppointmentDependencyTypeFinishToFinish
                Return "Bitirmek için Finish yazın"
            Case SchedulerStringId.Caption_AppointmentDependencyTypeFinishToStart
                Return "Başlatmak için Finish yazın"
            Case SchedulerStringId.Caption_AppointmentDependencyTypeStartToFinish
                Return "Bitirmek için Start yazın"
            Case SchedulerStringId.Caption_AppointmentDependencyTypeStartToStart
                Return "Başlatmak için Start yazın"
            Case SchedulerStringId.Caption_Busy
                Return "Dolu"
            Case SchedulerStringId.Caption_CalendarDetailsPrintStyle
                Return "Detay yazdırma stili"
            Case SchedulerStringId.Caption_CheckMappings
                Return "Eşleşmeleri kontrol et"
            Case SchedulerStringId.Caption_ColorConverterBlackAndWhite
                Return "Siyah beyaz"
            Case SchedulerStringId.Caption_ColorConverterFullColor
                Return "Renkli"
            Case SchedulerStringId.Caption_ColorConverterGrayScale
                Return "Grinin tonları"
            Case SchedulerStringId.Caption_DailyPrintStyle
                Return "Günlük yazdırma stili"
            Case SchedulerStringId.Caption_DayViewDescription
                Return "Gün görünümü"
            Case SchedulerStringId.Caption_DecreaseVisibleResourcesCount
                Return "Görünür kaynak sayısını azalt"
            Case SchedulerStringId.Caption_EmptyResource
                Return "Boş kaynak"
            Case SchedulerStringId.Caption_Event
                Return "Yeni Olay"
            Case SchedulerStringId.Caption_FirstVisibleResources
                Return "İlk görünecek kaynak"
            Case SchedulerStringId.Caption_Free
                Return "Boş"
            Case SchedulerStringId.Caption_GanttViewDescription
                Return "Gantt görünümü"
            Case SchedulerStringId.Caption_GroupByDate
                Return "Tarihe göre grupla"
            Case SchedulerStringId.Caption_GroupByDateDescription
                Return "Tarihe göre grupla"
            Case SchedulerStringId.Caption_GroupByNone
                Return "Gruplandırma yok"
            Case SchedulerStringId.Caption_GroupByNoneDescription
                Return "Gruplandırmayı iptal eder"
            Case SchedulerStringId.Caption_GroupByResourceDescription
                Return "Kaynaklara göre gruplandırmanızı sağlar"
            Case SchedulerStringId.Caption_GroupByResources
                Return "Kaynaklara göre grupla"
            Case SchedulerStringId.Caption_IncreaseVisibleResourcesCount
                Return "Görünen kaynak sayısını arttır"
            Case SchedulerStringId.Caption_LastVisibleResources
                Return "Son görünen kaynaklar"
            Case SchedulerStringId.Caption_MappingsValidation
                Return "Eşleşme doğrulaması"
            Case SchedulerStringId.Caption_MappingsWizard
                Return "Eşleşme sihirbazı"
            Case SchedulerStringId.Caption_MemoPrintStyle
                Return "Uzun metin yazdırma stili"
            Case SchedulerStringId.Caption_ModifyAppointmentDependencyMappingsTransactionDescription
                Return "Bağlantı eşleştirme işlemleri"
            Case SchedulerStringId.Caption_ModifyAppointmentDependencyStorageTransactionDescription
                Return "Bağlantı veritabanı işlemleri"
            Case SchedulerStringId.Caption_ModifyAppointmentMappingsTransactionDescription
                Return "Eşleştirme işlemleri"
            Case SchedulerStringId.Caption_ModifyAppointmentStorageTransactionDescription
                Return "Veritabanı işlemleri"
            Case SchedulerStringId.Caption_ModifyResourceMappingsTransactionDescription
                Return "Eşleştirme işlemleri"
            Case SchedulerStringId.Caption_ModifyResourceStorageTransactionDescription
                Return "Veritabanı işlemleri"
            Case SchedulerStringId.Caption_MonthlyPrintStyle
                Return "Aylık yazdırma stili"
            Case SchedulerStringId.Caption_MonthViewDescription
                Return "Aylık görünüm"
            Case SchedulerStringId.Caption_NAppointmentsAreSelected
                Return "{0} not seçildi"
            Case SchedulerStringId.Caption_NextAppointment
                Return "Sonraki not"
            Case SchedulerStringId.Caption_NextVisibleResources
                Return "Sonraki görünür kaynak"
            Case SchedulerStringId.Caption_NextVisibleResourcesPage
                Return "Sonraki görünür kaynak sayfası"
            Case SchedulerStringId.Caption_NoneRecurrence
                Return "Tekrar yok"
            Case SchedulerStringId.Caption_NoneReminder
                Return "Hatırlatma yok"
            Case SchedulerStringId.Caption_OnScreenResources
                Return "Ekrandaki kaynaklar"
            Case SchedulerStringId.Caption_OutOfOffice
                Return "Ofis dışında"
            Case SchedulerStringId.Caption_PleaseSeeAbove
                Return "Lütfen yukarı bakın"
            Case SchedulerStringId.Caption_PrevAppointment
                Return "Önceki not"
            Case SchedulerStringId.Caption_PrevVisibleResources
                Return "Önceki görünür kaynaklar"
            Case SchedulerStringId.Caption_PrevVisibleResourcesPage
                Return "Önceki görünür kaynaklar sayfası"
            Case SchedulerStringId.Caption_ReadOnly
                Return "Sadece okunur"
            Case SchedulerStringId.Caption_Recurrence
                Return "Tekrar"
            Case SchedulerStringId.Caption_RecurrenceEndTime
                Return "Bitiş"
            Case SchedulerStringId.Caption_RecurrenceLocation
                Return "Yer"
            Case SchedulerStringId.Caption_RecurrencePattern
                Return "Örnek"
            Case SchedulerStringId.Caption_RecurrenceShowTimeAs
                Return "Saati şöyle göster"
            Case SchedulerStringId.Caption_RecurrenceStartTime
                Return "Başlangıç"
            Case SchedulerStringId.Caption_RecurrenceSubject
                Return "Konu"
            Case SchedulerStringId.Caption_Reminder
                Return "Hatırlatma"
            Case SchedulerStringId.Caption_Reminders
                Return "Hatırlatma"
            Case SchedulerStringId.Caption_ResourceAll
                Return "Tüm kaynaklar"
            Case SchedulerStringId.Caption_ResourceNone
                Return "Kaynak yok"
            Case SchedulerStringId.Caption_SetupAppointmentDependencyStorage
                Return "Not bağlantı veritabanını ayarla"
            Case SchedulerStringId.Caption_SetupAppointmentMappings
                Return "Not eşleşmesini ayarla"
            Case SchedulerStringId.Caption_SetupAppointmentStorage
                Return "Not veritabanını ayarla"
            Case SchedulerStringId.Caption_SetupDependencyMappings
                Return "Bağlantı eşleşmelerini ayarla"
            Case SchedulerStringId.Caption_SetupResourceMappings
                Return "Kaynak eşleşmelerini ayarla"
            Case SchedulerStringId.Caption_SetupResourceStorage
                Return "Kaynak veritabanını ayarla"
            Case SchedulerStringId.Caption_ShadingApplyToAllDayArea
                Return "Gölgelendirmeyi tüm güne uygula"
            Case SchedulerStringId.Caption_ShadingApplyToAppointments
                Return "Gölgelendirmeyi notlara uygula"
            Case SchedulerStringId.Caption_ShadingApplyToAppointmentStatuses
                Return "Gölgelendirmeyi not durumlarına uygula"
            Case SchedulerStringId.Caption_ShadingApplyToCells
                Return "Gölgelendirmeyi hücrelere uygula"
            Case SchedulerStringId.Caption_ShadingApplyToHeaders
                Return "Gölgelendirmeyi başlıklara uygula"
            Case SchedulerStringId.Caption_ShadingApplyToTimeRulers
                Return "Gölgelendirmeyi zaman cetveline uygula"
            Case SchedulerStringId.Caption_SplitAppointment
                Return "Notu ayır"
            Case SchedulerStringId.Caption_StartTime
                Return "Başlama zamanı"
            Case SchedulerStringId.Caption_Tentative
                Return "Geçici"
            Case SchedulerStringId.Caption_TimelineViewDescription
                Return "Zaman cetveli şeklinde göster"
            Case SchedulerStringId.Caption_TrifoldPrintStyle
                Return "Trifold yazdırma stili"
            Case SchedulerStringId.Caption_UntitledAppointment
                Return "Başlıksız not"
            Case SchedulerStringId.Caption_VisibleResources
                Return "Görünür kaynaklar"
            Case SchedulerStringId.Caption_WeekDaysEveryDay
                Return "Her gün"
            Case SchedulerStringId.Caption_WeekDaysWeekendDays
                Return "Hafta sonu"
            Case SchedulerStringId.Caption_WeekDaysWorkDays
                Return "İş günleri"
            Case SchedulerStringId.Caption_WeeklyPrintStyle
                Return "Haftalık yazdırma stili"
            Case SchedulerStringId.Caption_WeekOfMonthFirst
                Return "Ay'ın ilk haftası"
            Case SchedulerStringId.Caption_WeekOfMonthFourth
                Return "Ay'ın dördüncü haftası"
            Case SchedulerStringId.Caption_WeekOfMonthLast
                Return "Ay'ın son haftası"
            Case SchedulerStringId.Caption_WeekOfMonthSecond
                Return "Ay'ın ikinci haftası"
            Case SchedulerStringId.Caption_WeekOfMonthThird
                Return "Ay'ın üçüncü haftası"
            Case SchedulerStringId.Caption_WeekViewDescription
                Return "Haftalık görünümde gösterir"
            Case SchedulerStringId.Caption_WorkWeekViewDescription
                Return "Çalışma haftası görünümü şeklinde gösterir"
            Case SchedulerStringId.DefaultToolTipStringFormat_SplitAppointment
                Return "Notu böl"
            Case SchedulerStringId.DescCmd_CellsAutoHeight
                Return "Otomatik hücre yüksekliği"
            Case SchedulerStringId.DescCmd_ChangeAppointmentReminderUI
                Return "Not hatırlatma arayüzünü değiştir"
            Case SchedulerStringId.DescCmd_ChangeSnapToCellsUI
                Return "Hücrelere yaklaştır görünümünü değiştir"
            Case SchedulerStringId.DescCmd_ChangeTimelineScaleWidth
                Return "Zaman cetveli genişliğini değiştir"
            Case SchedulerStringId.DescCmd_CompressWeekend
                Return "Haftasonunu sıkıştır"
            Case SchedulerStringId.DescCmd_CreateAppointmentDependency
                Return "Not bağlantısı ekle"
            Case SchedulerStringId.DescCmd_DeleteAppointment
                Return "Not'u sil"
            Case SchedulerStringId.DescCmd_DeleteAppointmentDependency
                Return "Not bağlantısını sil"
            Case SchedulerStringId.DescCmd_DeleteOccurrence
                Return "Tekrarlamayı sil"
            Case SchedulerStringId.DescCmd_DeleteSeries
                Return "Serileri Sil"
            Case SchedulerStringId.DescCmd_EditAppointmentDependency
                Return "Not bağlantısını düzenle"
            Case SchedulerStringId.DescCmd_GotoToday
                Return "Bugüne Git"
            Case SchedulerStringId.DescCmd_LabelAs
                Return "Etiket olarak"
            Case SchedulerStringId.DescCmd_NavigateBackward
                Return "Geri"
            Case SchedulerStringId.DescCmd_NavigateForward
                Return "İleri"
            Case SchedulerStringId.DescCmd_NewAppointment
                Return "Not Oluştur"
            Case SchedulerStringId.DescCmd_NewRecurringAppointment
                Return "Tekrarlı Not Oluştur"
            Case SchedulerStringId.DescCmd_OpenAppointment
                Return "Notu Aç"
            Case SchedulerStringId.DescCmd_OpenOccurrence
                Return "Oluşma zamanını aç"
            Case SchedulerStringId.DescCmd_OpenSchedule
                Return "Zamanlamayı aç"
            Case SchedulerStringId.DescCmd_OpenSeries
                Return "Serileri Aç"
            Case SchedulerStringId.DescCmd_Print
                Return "Yazdır"
                'Case SchedulerStringId.DescCmd_PrintPageSutup
                '    Return "Sayfa Yapılandır"
            Case SchedulerStringId.DescCmd_PrintPreview
                Return "Yazdırma Önizleme"
            Case SchedulerStringId.DescCmd_SaveSchedule
                Return "Zamanlamayı kaydet"
            Case SchedulerStringId.DescCmd_ShowTimeAs
                Return "Saat görünüm şekli"
            Case SchedulerStringId.DescCmd_ShowWorkTimeOnly
                Return "Sadece çalışma saatlerini göster"
            Case SchedulerStringId.DescCmd_SplitAppointment
                Return "Not'u böl"
            Case SchedulerStringId.DescCmd_TimeScalesMenu
                Return "Zaman skalası menüsü"
            Case SchedulerStringId.DescCmd_ToggleRecurrence
                Return "Tekrarları topla"
            Case SchedulerStringId.DescCmd_ViewZoomIn
                Return "Yaklaş"
            Case SchedulerStringId.DescCmd_ViewZoomOut
                Return "Uzaklaş"
            Case SchedulerStringId.DisplayName_Appointment
                Return "Not"
            Case SchedulerStringId.Format_CopyNOf
                Return "{1} kopyadan {0}"
            Case SchedulerStringId.Format_CopyOf
                Return "kopyası"
            Case SchedulerStringId.Format_TimeBeforeStart
                Return "Başlamadan önceki süre"
            Case SchedulerStringId.MemoPrintDateFormat
                Return "Tarih formatı"
            Case SchedulerStringId.MenuCmd_10Minutes
                Return "10 dakika"
            Case SchedulerStringId.MenuCmd_15Minutes
                Return "15 dakika"
            Case SchedulerStringId.MenuCmd_20Minutes
                Return "20 dakika"
            Case SchedulerStringId.MenuCmd_30Minutes
                Return "30 dakika"
            Case SchedulerStringId.MenuCmd_5Minutes
                Return "5 dakika"
            Case SchedulerStringId.MenuCmd_60Minutes
                Return "60 dakika"
            Case SchedulerStringId.MenuCmd_6Minutes
                Return "6 dakika"
            Case SchedulerStringId.MenuCmd_AppointmentCancel
                Return "İptal"
            Case SchedulerStringId.MenuCmd_AppointmentCopy
                Return "Kopyala"
            Case SchedulerStringId.MenuCmd_AppointmentLabelAnniversary
                Return "yıl dönümü"
            Case SchedulerStringId.MenuCmd_AppointmentLabelBirthday
                Return "Doğum Günü"
            Case SchedulerStringId.MenuCmd_AppointmentLabelBusiness
                Return "İş"
            Case SchedulerStringId.MenuCmd_AppointmentLabelImportant
                Return "Önemli"
            Case SchedulerStringId.MenuCmd_AppointmentLabelMustAttend
                Return "İlgi Gerektirir"
            Case SchedulerStringId.MenuCmd_AppointmentLabelNeedsPreparation
                Return "Hazırlık Gerektirir"
            Case SchedulerStringId.MenuCmd_AppointmentLabelNone
                Return "Yok"
            Case SchedulerStringId.MenuCmd_AppointmentLabelPersonal
                Return "Kişisel"
            Case SchedulerStringId.MenuCmd_AppointmentLabelPhoneCall
                Return "Telefonla Ara"
            Case SchedulerStringId.MenuCmd_AppointmentLabelTravelRequired
                Return "Yolculuk Gerektirir"
            Case SchedulerStringId.MenuCmd_AppointmentLabelVacation
                Return "Tatil"
            Case SchedulerStringId.MenuCmd_AppointmentMove
                Return "Taşı"
            Case SchedulerStringId.MenuCmd_Busy
                Return "Meşgul"
            Case SchedulerStringId.MenuCmd_CellsAutoHeight
                Return "Otomotik yükseklik"
            Case SchedulerStringId.MenuCmd_ChangeAppointmentReminderUI
                Return "Hatırlatma arayüzünü değiştir"
            Case SchedulerStringId.MenuCmd_ChangeSnapToCellsUI
                Return "Hücreye sığdır"
            Case SchedulerStringId.MenuCmd_ChangeTimelineScaleWidth
                Return "Zaman çizgisi ölçeği"
            Case SchedulerStringId.MenuCmd_CompressWeekend
                Return "Haftasonunu sıkıştır"
            Case SchedulerStringId.MenuCmd_CreateAppointmentDependency
                Return "Not'a bağlantı ekle"
            Case SchedulerStringId.MenuCmd_CustomizeCurrentView
                Return "Geçerli görünümü özelleştir"
            Case SchedulerStringId.MenuCmd_CustomizeTimeRuler
                Return "Zaman cetvelini özelleştir"
            Case SchedulerStringId.MenuCmd_DeleteAppointment
                Return "Not'u sil"
            Case SchedulerStringId.MenuCmd_DeleteAppointmentDependency
                Return "Not'un bağlantısını sil"
            Case SchedulerStringId.MenuCmd_DeleteOccurrence
                Return "Tekrarlamayı sil"
            Case SchedulerStringId.MenuCmd_DeleteSeries
                Return "Serileri sil"
            Case SchedulerStringId.MenuCmd_EditAppointmentDependency
                Return "Not bağlantısını düzenle"
            Case SchedulerStringId.MenuCmd_EditSeries
                Return "Serileri Düzenle"
            Case SchedulerStringId.MenuCmd_Free
                Return "Boş"
            Case SchedulerStringId.MenuCmd_GotoDate
                Return "Tarihe git"
            Case SchedulerStringId.MenuCmd_GotoThisDay
                Return "Şu güne git"
            Case SchedulerStringId.MenuCmd_GotoToday
                Return "Bugüne git"
            Case SchedulerStringId.MenuCmd_LabelAs
                Return "Etiket olarak"
            Case SchedulerStringId.MenuCmd_NavigateBackward
                Return "Geri"
            Case SchedulerStringId.MenuCmd_NavigateForward
                Return "İleri"
            Case SchedulerStringId.MenuCmd_NewAllDayEvent
                Return "Yeni tam gün olayı"
            Case SchedulerStringId.MenuCmd_NewAppointment
                Return "Not Oluştur"
            Case SchedulerStringId.MenuCmd_NewRecurringAppointment
                Return "Tekrarlanan Not Oluştur"
            Case SchedulerStringId.MenuCmd_NewRecurringEvent
                Return "Tekrarlanan Olay Oluştur"
            Case SchedulerStringId.MenuCmd_OpenAppointment
                Return "Notu Aç"
            Case SchedulerStringId.MenuCmd_OpenOccurrence
                Return "Tekrarını Aç"
            Case SchedulerStringId.MenuCmd_OpenSchedule
                Return "Zamanlamaı Aç"
            Case SchedulerStringId.MenuCmd_OpenSeries
                Return "Serileri Aç"
            Case SchedulerStringId.MenuCmd_OtherSettings
                Return "Diğer Seçenekler"
            Case SchedulerStringId.MenuCmd_OutOfOffice
                Return "Ofis Dışında"
            Case SchedulerStringId.MenuCmd_Print
                Return "Yazdır"
            Case SchedulerStringId.MenuCmd_PrintAppointment
                Return "Notu Yazdır"
            Case SchedulerStringId.MenuCmd_PrintPageSetup
                Return "Sayfa Yapısı"
            Case SchedulerStringId.MenuCmd_PrintPreview
                Return "sayfa Önizleme"
            Case SchedulerStringId.MenuCmd_RestoreOccurrence
                Return "Tekrarlamayı geri al"
            Case SchedulerStringId.MenuCmd_SaveSchedule
                Return "Zamanlamayı kaydet"
            Case SchedulerStringId.MenuCmd_ShowTimeAs
                Return "Saati şöyle göster"
            Case SchedulerStringId.MenuCmd_ShowWorkTimeOnly
                Return "Sadece hafta içi günleri göster"
            Case SchedulerStringId.MenuCmd_SwitchToDayView
                Return "gün görünümüne geç"
            Case SchedulerStringId.MenuCmd_SwitchToGanttView
                Return "Gantt görünümüne geç"
            Case SchedulerStringId.MenuCmd_SwitchToGroupByDate
                Return "Darih gruplamasına geç"
            Case SchedulerStringId.MenuCmd_SwitchToGroupByNone
                Return "Gruplandırmayı iptal et"
            Case SchedulerStringId.MenuCmd_SwitchToGroupByResource
                Return "Kaynak gruplandırmasına geç"
            Case SchedulerStringId.MenuCmd_SwitchToMonthView
                Return "Ay görünümüne geç"
            Case SchedulerStringId.MenuCmd_SwitchToTimelineView
                Return "Zaman çizgisi görünümüne geç"
            Case SchedulerStringId.MenuCmd_SwitchToWeekView
                Return "Hafta görünümüne geç"
            Case SchedulerStringId.MenuCmd_SwitchToWorkWeekView
                Return "Çalışma haftası görünümüne geç"
            Case SchedulerStringId.MenuCmd_SwitchViewMenu
                Return "Görünüm değiştir"
            Case SchedulerStringId.MenuCmd_Tentative
                Return "Geçici"
            Case SchedulerStringId.MenuCmd_TimeScaleCaptionsMenu
                Return "Menü Başlığı"
            Case SchedulerStringId.MenuCmd_TimeScaleDay
                Return "Gün"
            Case SchedulerStringId.MenuCmd_TimeScaleHour
                Return "Saat"
            Case SchedulerStringId.MenuCmd_TimeScaleMonth
                Return "Ay"
            Case SchedulerStringId.MenuCmd_TimeScaleQuarter
                Return "3 aylık"
            Case SchedulerStringId.MenuCmd_TimeScalesMenu
                Return "Menü"
            Case SchedulerStringId.MenuCmd_TimeScaleWeek
                Return "Hafta"
            Case SchedulerStringId.MenuCmd_TimeScaleYear
                Return "Yıl"
            Case SchedulerStringId.MenuCmd_ToggleRecurrence
                Return "Tekrarları topla"
            Case SchedulerStringId.MenuCmd_ViewZoomIn
                Return "Yakınlaş"
            Case SchedulerStringId.MenuCmd_ViewZoomOut
                Return "Uzaklaş"
            Case SchedulerStringId.Msg_ApplyToAllStyles
                Return "Tüm stillere uygula"
            Case SchedulerStringId.Msg_CantFitIntoPage
                Return "Sayfa içine sığdırılamadı"
            Case SchedulerStringId.Msg_Conflict
                Return "Çakışma"
            Case SchedulerStringId.Msg_DuplicateCustomFieldMappings
                Return "Özel alan eşleştirmelerinde çakışma"
            Case SchedulerStringId.Msg_DuplicateMappingMember
                Return "Çakışan eşleşme üyesi"
            Case SchedulerStringId.Msg_InconsistentRecurrenceInfoMapping
                Return "Uyuşmayan Tekrarlama bilgisi eşleşmesi"
            Case SchedulerStringId.Msg_IncorrectMappingsQuestion
                Return "Geçersiz eşleşme sorusu"
            Case SchedulerStringId.Msg_InternalError
                Return "İç hata"
            Case SchedulerStringId.Msg_InvalidAppointmentDuration
                Return "Geçersiz not süresi"
            Case SchedulerStringId.Msg_InvalidDayCount
                Return "Geçersiz gün sayısı"
            Case SchedulerStringId.Msg_InvalidDayCountValue
                Return "Geçersiz gün sayısı değeri"
            Case SchedulerStringId.Msg_InvalidDayNumber
                Return "Geçersiz gün numarası"
            Case SchedulerStringId.Msg_InvalidDayNumberValue
                Return "Geçersiz gün numarası değeri"
            Case SchedulerStringId.Msg_InvalidDayOfWeek
                Return "Geçersiz hafta günü"
            Case SchedulerStringId.Msg_InvalidDayOfWeekForDailyRecurrence
                Return "Günlük tekrar için geçersiz hafta günü."
            Case SchedulerStringId.Msg_InvalidEndDate
                Return "Geçersiz bitiş tarihi"
            Case SchedulerStringId.Msg_InvalidInputFile
                Return "Geçersiz dosya"
            Case SchedulerStringId.Msg_InvalidMonthCount
                Return "Geçersiz ay sayısı"
            Case SchedulerStringId.Msg_InvalidMonthCountValue
                Return "Geçersiz ay sayısı değeri"
            Case SchedulerStringId.Msg_InvalidOccurrencesCount
                Return "Geçersiz hadise sayısı"
            Case SchedulerStringId.Msg_InvalidOccurrencesCountValue
                Return "Geçersiz hadise sayısı değeri"
            Case SchedulerStringId.Msg_InvalidReminderTimeBeforeStart
                Return "başlamadan önceki hatırlatma süresi geçersiz"
            Case SchedulerStringId.Msg_InvalidSize
                Return "Geçersiz boyut"
            Case SchedulerStringId.Msg_InvalidTimeOfDayInterval
                Return "Saat sıklığı geçersiz"
            Case SchedulerStringId.Msg_InvalidWeekCount
                Return "Geçersiz hafta sayısı"
            Case SchedulerStringId.Msg_InvalidWeekCountValue
                Return "Geçersiz hafta sayısı değeri"
            Case SchedulerStringId.Msg_InvalidYearCount
                Return "Geçersiz yıl sayısı"
            Case SchedulerStringId.Msg_InvalidYearCountValue
                Return "Geçersiz yıl sayısı değeri"
            Case SchedulerStringId.Msg_IsNotValid
                Return "Geçersiz"
            Case SchedulerStringId.Msg_LoadCollectionFromXml
                Return "Koleksiyonu XML'den yükle"
            Case SchedulerStringId.Msg_MappingsCheckPassedOk
                Return "Eşleşme kontrolü tamamlandı"
            Case SchedulerStringId.Msg_MemoPrintNoSelectedItems
                Return "Seçili öğe bulunamadı"
            Case SchedulerStringId.Msg_MissingMappingMember
                Return "Eşleşme alanı bulunamadı"
            Case SchedulerStringId.Msg_MissingRequiredMapping
                Return "Gerekli bir eşleşme bulunamadı"
            Case SchedulerStringId.Msg_NoMappingForObject
                Return "Nesne için eşleşme yok"
            Case SchedulerStringId.Msg_OutlookCalendarNotFound
                Return "Outlook Calendar bulunamadı"
            Case SchedulerStringId.Msg_OverflowTimeOfDayInterval
                Return "Günlük saat sıklığı taşıyor"
            Case SchedulerStringId.Msg_PrintStyleNameExists
                Return "Yazdırma stili adı zaten var"
            Case SchedulerStringId.Msg_RecurrenceExceptionsWillBeLost
                Return "Tekrarlama istisnası kaybolacak"
            Case SchedulerStringId.Msg_Warning
                Return "Dikkat"
            Case SchedulerStringId.Msg_WarningAppointmentDeleted
                Return "Dikkat... Not silindi."
            Case SchedulerStringId.Msg_WarningDayNumber
                Return "Dikkat... Gün sayısı"
            Case SchedulerStringId.Msg_XtraSchedulerNotAssigned
                Return "XtraScheduler atanmamış"
            Case SchedulerStringId.Reporting_NotAssigned_TimeCells
                Return "Zaman hücresi atanmamış"
            Case SchedulerStringId.Reporting_NotAssigned_View
                Return "Görünüm atanmamış"
            Case SchedulerStringId.TextAppointmentSnapToCells_Always
                Return "Daima"
            Case SchedulerStringId.TextAppointmentSnapToCells_Auto
                Return "Otomatik"
            Case SchedulerStringId.TextAppointmentSnapToCells_Disabled
                Return "Devre dışı"
            Case SchedulerStringId.TextAppointmentSnapToCells_Never
                Return "Asla"
            Case SchedulerStringId.TextDailyPatternString_EveryDay
                Return "Her gün"
            Case SchedulerStringId.TextDailyPatternString_EveryDays
                Return "Tüm günler"
            Case SchedulerStringId.TextDailyPatternString_EveryWeekDay
                Return "Hafta içi her gün"
            Case SchedulerStringId.TextDailyPatternString_EveryWeekend
                Return "Hafta sonu her gün"
            Case SchedulerStringId.TextDuration_ForPattern
                Return "Desen için"
            Case SchedulerStringId.TextDuration_FromForDays
                Return "{0} günlüğüne"
            Case SchedulerStringId.TextDuration_FromForDaysHours
                Return "{0} gün {1} saatliğine"
            Case SchedulerStringId.TextDuration_FromForDaysHoursMinutes
                Return "{0} gün {1} saat {3} dakikalığına"
            Case SchedulerStringId.TextDuration_FromForDaysMinutes
                Return "{0} gün {1} dakikalığına"
            Case SchedulerStringId.TextDuration_FromTo
                Return "a kadar"
            Case SchedulerStringId.TextRecurrenceTypeDaily
                Return "Günlük tekrar tipi"
            Case SchedulerStringId.TextWeekly_7Day
                Return "7 gün"
            Case SchedulerStringId.TextWeeklyPatternString_EveryWeek
                Return "Her hafta"
            Case SchedulerStringId.TextWeeklyPatternString_EveryWeeks
                Return "Tüm haftalar"
            Case SchedulerStringId.TimeScaleDisplayName_Day
                Return "Gün"
            Case SchedulerStringId.TimeScaleDisplayName_Hour
                Return "Saat"
            Case SchedulerStringId.TimeScaleDisplayName_Month
                Return "Ay"
            Case SchedulerStringId.TimeScaleDisplayName_Quarter
                Return "3 aylık"
            Case SchedulerStringId.TimeScaleDisplayName_Week
                Return "Hafta"
            Case SchedulerStringId.TimeScaleDisplayName_Year
                Return "Yıl"
            Case SchedulerStringId.ViewDisplayName_Day
                Return "Gün"
            Case SchedulerStringId.ViewDisplayName_Gantt
                Return "Gantt"
            Case SchedulerStringId.ViewDisplayName_Month
                Return "Ay"
            Case SchedulerStringId.ViewDisplayName_Timeline
                Return "Zaman cetveli"
            Case SchedulerStringId.ViewDisplayName_Week
                Return "Hafta"
            Case SchedulerStringId.ViewDisplayName_WorkDays
                Return "İşgünleri"
            Case SchedulerStringId.ViewShortDisplayName_Day
                Return "Gün"
            Case SchedulerStringId.ViewShortDisplayName_Gantt
                Return "Gantt"
            Case SchedulerStringId.ViewShortDisplayName_Month
                Return "Ay"
            Case SchedulerStringId.ViewShortDisplayName_Timeline
                Return "Zaman cetveli"
            Case SchedulerStringId.ViewShortDisplayName_Week
                Return "Hafta"
            Case SchedulerStringId.ViewShortDisplayName_WorkDays
                Return "İşgünleri"
            Case Else
                Return "!!! yerelliştirmir."
        End Select
    End Function
End Class
