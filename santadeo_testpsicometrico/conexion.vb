Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Module Conexion
    Public conexiones As SqlConnection
    Public cone As SqlConnection
    Public insercion As SqlCommand
    Public insert As SqlCommand
    Public insertion As SqlCommand
    Public agregac As SqlCommand
    Public selectiid As SqlCommand
    Public nombre, escolaridad, puesto As String
    Public edad As Integer

    'FUNCION DE CONEXION A LA BASE DE DATOS SQL SERVER' 
    Sub abrir()
        Try
            conexiones = New SqlConnection("Data Source=192.168.3.254;Initial Catalog=Vistas;User ID=sa;Password=inventumc762$")
            conexiones.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de conexion")
            conexiones.Close()
        End Try
    End Sub
    Function insertar(ByVal id As Integer, ByVal id_candidato As Integer, ByVal nombre As String, ByVal fecha As Date, ByVal estudios As String, ByVal edad As String, ByVal puesto As String) As String
        Dim resul As String = ""
        Try
            insercion = New SqlCommand("SET DATEFORMAT dmy    insert into rh_test_merril (id_terman_merril,id_candidato,tst_nombre,tst_fecha,tst_escolaridad,tst_edad,tst_puesto) values(" & id & "," & id_candidato & ",'" & nombre & "','" & fecha & "','" & estudios & "','" & edad & "','" & puesto & "')", conexiones)
            insercion.ExecuteNonQuery()
            resul = "MUCHA SUERTE!!!"
            conexiones.Close()
        Catch ex As Exception
            resul = "Error al insertar los datos" + ex.ToString
            MessageBox.Show(ex.Message, "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexiones.Close()
        End Try
        Return resul
    End Function
    Function agregar(ByVal id As Integer, ByVal id_candidato As Integer, ByVal nombre As String, ByVal fecha As Date, ByVal estudios As String, ByVal edad As String, ByVal puesto As String) As String
        Dim result As String = ""
        Try
            insert = New SqlCommand("SET DATEFORMAT dmy   insert into rh_test_cleaver (id_cleaver,id_candidato,tst_nombre,tst_fecha,tst_escolaridad,tst_edad,tst_puesto) values(" & id & "," & id_candidato & ",'" & nombre & "','" & fecha & "','" & estudios & "','" & edad & "','" & puesto & "')", conexiones)
            insert.ExecuteNonQuery()
            result = "MUCHA SUERTE!!!"
            conexiones.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            result = "Error al insertar los datos" + ex.ToString
            conexiones.Close()
        End Try
        Return result
    End Function

    Function registro(ByVal idC As Integer, ByVal fechaI As String, ByVal fechaF As String, ByVal empresa As String, ByVal puesto As String, ByVal actividades As String, ByVal telefonoE As String, ByVal separacion As String)
        Dim comando As SqlCommand
        Try
            abrir()
            comando = New SqlCommand("SET DATEFORMAT dmy  insert into rh_candidatos_explab (id_candidato,d_inicio_empleo,d_fin_empleo,exp_nombre_empresa,exp_puesto_empresa,exp_activ_realizadas,exp_tel_empresa,exp_motivo_separacion) values (" & idC & ",'" & fechaI & "','" & fechaF & "','" & empresa & "','" & puesto & "','" & actividades & "','" & telefonoE & "','" & separacion & "')", conexiones)
            comando.ExecuteNonQuery()
            conexiones.Close()
        Catch ex As Exception
            conexiones.Close()
            MessageBox.Show(ex.Message, "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function
    Function agregarcandidato(ByVal nombre As String, ByVal fechaN As String, ByVal edad As Integer, ByVal direccion As String, ByVal ciudad As String,
                              ByVal estado As String, ByVal telefono As String, ByVal CP As String, ByVal mail As String, ByVal fechaP As String,
                              ByVal titulo As String, ByVal sueldo As String, ByVal viajar As String, ByVal radicar As String, ByVal nivelS As String,
                              ByVal lic As String, ByVal situacionA As String, ByVal experiencia As String)
        Try
            abrir()
            agregac = New SqlCommand("SET DATEFORMAT dmy  insert into rh_candidatos_empleos (rh_nombre_candidato,rh_fecha_nac,rh_edad,rh_direcccion,rh_ciudad,rh_estado,rh_num_tel,c_codigo_post,rh_email,rh_fecha_postulacion,rh_titulo_empleo,rh_sueldo_deseado,rh_dispvia_fuera,rh_disprad_fuera,rh_nivel_estud,rh_licenciatura,rh_sit_acad,rh_years_exp) values ('" & nombre & "','" & fechaN & "','" & edad & "','" & direccion & "', '" & ciudad & "','" & estado & "','" & telefono & "','" & CP & "','" & mail & "','" & fechaP & "','" & titulo & "'," & sueldo & ",'" & viajar & "','" & radicar & "','" & nivelS & "','" & lic & "','" & situacionA & "'," & experiencia & ")", conexiones)
            agregac.ExecuteNonQuery()
            conexiones.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexiones.Close()
        End Try
        Return Nothing
    End Function

    Function selectid(ByVal nombreC As String)
        Dim id As Integer
        'Dim lector5 As SqlDataReader

        Try
            abrir()
            Dim query5 As String = "select id_candidato from vistas.dbo.rh_candidatos_empleos where rh_nombre_candidato='" & nombreC & "'"
            Dim comando5 As SqlCommand
            Dim lector5 As SqlDataReader
            comando5 = New SqlCommand(query5, conexiones) 'esto verifica si se encuentra o no el id ingresado para agragarlo o no a la BD
            lector5 = comando5.ExecuteReader
            If lector5.Read Then
                id = CInt(lector5(0).ToString)
                lector5.Close()
            End If
            'selectiid = New SqlCommand("select id_candidato from rh_candidatos_empleos where rh_nombre_candidato='" & nombreC & "'", conexiones)
            ''selectiid.ExecuteNonQuery()
            'lector5 = selectiid.ExecuteReader


            lector5.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al consultar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return id
    End Function
    Function f_test_zavic(ByVal id As String, ByVal nombre As String, ByVal fecha As String, ByVal escolaridad As String, ByVal edad As String, ByVal puesto As String, ByVal t_moral As Integer, ByVal t_legabilidad As Integer, ByVal t_indiferencia As Integer, ByVal t_corrupto As Integer, ByVal t_economico As Integer, ByVal t_politico As Integer, ByVal t_social As Integer, ByVal t_religioso As Integer)
        Dim comando As SqlCommand
        Try
            abrir()
            comando = New SqlCommand("SET DATEFORMAT dmy  insert into rh_test_zavic (id_candidato,t_nombre,d_fecha_test,t_escolaridad,t_edad,t_puesto,t_totl_moral,t_tot_legalidad,t_tot_indiferencia,t_tot_corrupto,t_tot_economico,t_tot_politico,t_tot_social,t_tot_religioso) values (" & id & ",'" & nombre & "','" & fecha & "','" & escolaridad & "','" & edad & "','" & puesto & "'," & t_moral & "," & t_legabilidad & "," & t_indiferencia & "," & t_corrupto & "," & t_economico & "," & t_politico & "," & t_social & "," & t_religioso & ")", conexiones)
            comando.ExecuteNonQuery()
            conexiones.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexiones.Close()
        End Try

        Return Nothing
    End Function

    Function actualizaZavic(ByVal id As String, ByVal fecha As String, ByVal t_moral As Integer, ByVal t_legabilidad As Integer, ByVal t_indiferencia As Integer, ByVal t_corrupto As Integer, ByVal t_economico As Integer, ByVal t_politico As Integer, ByVal t_social As Integer, ByVal t_religioso As Integer)
        Dim comando As SqlCommand
        Try
            abrir()
            comando = New SqlCommand("SET DATEFORMAT dmy  update rh_test_zavic set d_fecha_test='" & fecha & "',t_totl_moral=" & t_moral & ",t_tot_legalidad= " & t_legabilidad & ",t_tot_indiferencia=" & t_indiferencia & ",t_tot_corrupto=" & t_corrupto & ",t_tot_economico= " & t_economico & ",t_tot_politico=" & t_politico & ",t_tot_social=" & t_social & ",t_tot_religioso=" & t_religioso & " where id_candidato=" & id & "", conexiones)
            comando.ExecuteNonQuery()
            conexiones.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexiones.Close()
        End Try

        Return Nothing
    End Function

    Function elimina_curriculum(ByVal idcurriculum As Integer)
        Try
            Dim comando As SqlCommand
            abrir()
            comando = New SqlCommand("delete from rh_candidatos_curriculums where id_candidato=" + CStr(idcurriculum) + "", conexiones)
            comando.ExecuteNonQuery()
            conexiones.Close()
        Catch ex As Exception
            conexiones.Close()
            MessageBox.Show(ex.Message, "Error al eliminar curriculum", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function
    Function informacion(ByVal id As Integer)
       
        Try
            abrir()
            Dim query As String = "select rh_nombre_candidato,rh_edad,rh_nivel_estud,rh_titulo_empleo from rh_candidatos_empleos where id_candidato=" & id & ""
            Dim comando As SqlCommand
            Dim lector As SqlDataReader
            comando = New SqlCommand(query, conexiones)
            lector = comando.ExecuteReader
            If lector.Read Then
                nombre = lector(0).ToString
                edad = CInt(lector(1).ToString)
                escolaridad = lector(2).ToString
                puesto = lector(3).ToString
            End If
            lector.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al obtener información", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function

    Function TotalyCI(ByVal total As Integer, ByVal ci As Integer)
        Dim comando As SqlCommand
        Try
            abrir()
            comando = New SqlCommand("update rh_test_merril set total=" & total & ", CI=" & ci & " where id_candidato=" & registro1.identificador & "", conexiones)
            comando.ExecuteNonQuery()
            conexiones.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexiones.Close()
        End Try
        Return Nothing
    End Function

    Function calculaRango(ByVal id As Integer)
        Dim r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, rg As String
        Try
            abrir()
            Dim query As String = "SELECT (CASE Serie1 WHEN 16 THEN 'Sobresaliente' WHEN 15 THEN 'Superior' WHEN 14 THEN 'Medio alto' WHEN 13 THEN 'Térm. Medio' WHEN 12 THEN 'Térm. Medio' WHEN 11 THEN 'Medio Bajo' WHEN 10 THEN 'Medio bajo' WHEN 9 THEN 'Inferior' WHEN 8 THEN 'Inferior' WHEN 7 THEN 'Deficiente' ELSE 'Deficiente' END) AS Rango1, " +
                                                        " (CASE Serie2 WHEN 22 THEN 'Sobresaliente' WHEN 20 THEN 'Superior' WHEN 18 THEN 'Medio alto' WHEN 16 THEN 'Térm. Medio' WHEN 15 THEN 'Térm. Medio' WHEN 14 THEN 'Térm. Medio' WHEN 13 THEN 'Térm. Medio' WHEN 12 THEN 'Térm. Medio' WHEN 10 THEN 'Medio bajo' WHEN 8 THEN 'Inferior'" +
                                                        "  WHEN 6 THEN 'Deficiente' ELSE 'Deficiente' END) AS Rango2, " +
                                                        " (CASE Serie3 WHEN 30 THEN 'Sobresaliente' WHEN 29 THEN 'Sobresaliente' WHEN 28 THEN 'Superior' WHEN 27 THEN 'Superior' WHEN 26 THEN 'Medio alto' WHEN 25 THEN 'Medio alto' WHEN 24 THEN 'Medio alto' WHEN 23 THEN 'Medio alto' WHEN 22 THEN 'Térm. Medio' WHEN 21 THEN 'Térm. Medio' " +
                                                       "   WHEN 20 THEN 'Térm. Medio' WHEN 19 THEN 'Térm. Medio' WHEN 18 THEN 'Térm. Medio' WHEN 17 THEN 'Térm. Medio' WHEN 16 THEN 'Térm. Medio' WHEN 15 THEN 'Térm. Medio' WHEN 14 THEN 'Térm. Medio' WHEN 13 THEN 'Medio bajo' WHEN 12 THEN 'Medio bajo' WHEN 11 THEN 'Inferior' WHEN 10 THEN" +
                                                       " 'Inferior' WHEN 9 THEN 'Inferior' WHEN 8 THEN 'Inferior' WHEN 7 THEN 'Deficiente' ELSE 'Deficiente' END) AS Rango3, " +
                                                      "   (CASE Serie4 WHEN 18 THEN 'Sobresaliente' WHEN 17 THEN 'Superior' WHEN 16 THEN 'Superior' WHEN 15 THEN 'Medio alto' WHEN 14 THEN 'Medio alto' WHEN 13 THEN 'Térm. Medio' WHEN 12 THEN 'Térm. Medio' WHEN 11 THEN 'Térm. Medio' WHEN 10 THEN 'Térm. Medio' WHEN 9 THEN 'Medio bajo'" +
                                                       "   WHEN 8 THEN 'Medio bajo' WHEN 7 THEN 'Medio bajo' WHEN 6 THEN 'Inferior' WHEN 5 THEN 'Deficiente' ELSE 'Deficiente' END) AS Rango4, " +
                                                       "  (CASE Serie5 WHEN 24 THEN 'Sobresaliente' WHEN 22 THEN 'Superior' WHEN 21 THEN 'Superior' WHEN 20 THEN 'Superior' WHEN 18 THEN 'Medio alto' WHEN 17 THEN 'Medio alto' WHEN 16 THEN 'Medio alto' WHEN 14 THEN 'Térm. Medio' WHEN 13 THEN 'Térm. Medio' WHEN 12 THEN 'Térm. Medio'" +
                                                       "   WHEN 10 THEN 'Medio bajo' WHEN 9 THEN 'Medio bajo' WHEN 8 THEN 'Medio bajo' WHEN 6 THEN 'Inferior' WHEN 4 THEN 'Deficiente' ELSE 'Deficiente' END) AS Rango5, " +
                                                       "  (CASE Serie6 WHEN 20 THEN 'Sobresaliente' WHEN 19 THEN 'Superior' WHEN 18 THEN 'Superior' WHEN 17 THEN 'Medio alto' WHEN 16 THEN 'Medio alto' WHEN 15 THEN 'Medio alto' WHEN 14 THEN 'Térm. Medio' WHEN 13 THEN 'Térm. Medio' WHEN 12 THEN 'Térm. Medio' WHEN 11 THEN 'Térm. Medio'" +
                                                       "   WHEN 10 THEN 'Térm. Medio' WHEN 9 THEN 'Térm. Medio' WHEN 8 THEN 'Medio bajo' WHEN 7 THEN 'Medio bajo' WHEN 6 THEN 'Inferior' WHEN 5 THEN 'Inferior' WHEN 4 THEN 'Deficiente' ELSE 'Deficiente' END) AS Rango6, " +
                                                       "  (CASE Serie7 WHEN 20 THEN 'Sobresaliente' WHEN 19 THEN 'Sobresaliente' WHEN 18 THEN 'Superior' WHEN 17 THEN 'Medio alto' WHEN 16 THEN 'Medio alto' WHEN 15 THEN 'Térm. Medio' WHEN 14 THEN 'Térm. Medio' WHEN 13 THEN 'Térm. Medio' WHEN 12 THEN 'Térm. Medio' WHEN 11 THEN 'Térm. Medio'" +
                                                      "    WHEN 10 THEN 'Térm. Medio' WHEN 9 THEN 'Térm. Medio' WHEN 8 THEN 'Medio bajo' WHEN 7 THEN 'Medio bajo' WHEN 6 THEN 'Medio bajo' WHEN 5 THEN 'Inferior' WHEN 4 THEN 'Deficiente' ELSE 'Deficiente' END) AS Rango7, " +
                                                      "   (CASE Serie8 WHEN 17 THEN 'Sobresaliente' WHEN 16 THEN 'Superior' WHEN 15 THEN 'Superior' WHEN 14 THEN 'Medio alto' WHEN 13 THEN 'Medio alto' WHEN 12 THEN 'Térm. Medio' WHEN 11 THEN 'Térm. Medio' WHEN 10 THEN 'Térm. Medio' WHEN 9 THEN 'Térm. Medio' WHEN 8 THEN 'Térm. Medio' WHEN" +
                                                      "    7 THEN 'Medio bajo' WHEN 6 THEN 'Inferior' WHEN 5 THEN 'Deficiente' ELSE 'Deficiente' END) AS Rango8, " +
                                                       "  (CASE Serie9 WHEN 18 THEN 'Sobresaliente' WHEN 17 THEN 'Superior' WHEN 16 THEN 'Medio alto' WHEN 15 THEN 'Térm. Medio' WHEN 14 THEN 'Térm. Medio' WHEN 13 THEN 'Térm. Medio' WHEN 12 THEN 'Térm. Medio' WHEN 11 THEN 'Térm. Medio' WHEN 10 THEN 'Térm. Medio' WHEN 9 THEN 'Medio bajo'" +
                                                       "   WHEN 8 THEN 'Inferior' WHEN 7 THEN 'Inferior' WHEN 6 THEN 'Deficiente' ELSE 'Deficiente' END) AS Rango9, " +
                                                     "    (CASE Serie10 WHEN 22 THEN 'Sobresaliente' WHEN 21 THEN 'Sobresaliente' WHEN 20 THEN 'Sobresaliente' WHEN 18 THEN 'Superior' WHEN 16 THEN 'Medio alto' WHEN 14 THEN 'Térm. Medio' WHEN 13 THEN 'Térm. Medio' WHEN 12 THEN 'Térm. Medio' WHEN 11 THEN 'Térm. Medio' WHEN 10 THEN" +
                                                     "  'Térm. Medio' WHEN 8 THEN 'Medio bajo' WHEN 6 THEN 'Inferior' WHEN 4 THEN 'Deficiente' ELSE 'Deficiente' END) AS Rango10," +
              "  (CASE when Ci>=140 then 'Sobresaliente' when Ci between 120 and 139 then 'Superior' " +
              "  when Ci between 110 and 119 then 'Termino medio alto' when Ci between 90 and 109 then 'Normal'" +
              "  when Ci between 80 and 89 then 'Termino medio bajo' when Ci between 70 and 79 then 'Inferior'" +
              "  when Ci <=69 then 'Deficiente' else 'Deficiente' end) as RangoG" +
                             "  FROM            (SELECT        id_candidato, tst_nombre AS CANDIDATO, tst_fecha AS FECHA, tst_edad AS EDAD, tst_puesto AS PSOLICITADO, CI as Ci, " +
                                                                                 "  SerieI_1 + SerieI_2 + SerieI_3 + SerieI_4 + SerieI_5 + SerieI_6 + SerieI_7 + SerieI_8 + SerieI_9 + SerieI_10 + SerieI_11 + SerieI_12 + SerieI_13 + SerieI_14 + SerieI_15 + SerieI_1 AS Serie1," +
                                                                                 "   (SerieII_1 + SerieII_2 + SerieII_3 + SerieII_4 + SerieII_5 + SerieII_6 + SerieII_7 + SerieII_8 + SerieII_9 + SerieII_10 + SerieII_11) * 2 AS Serie2, " +
                                                                                 "  (SerieIII_1 + SerieIII_2 + SerieIII_3 + SerieIII_4 + SerieIII_5 + SerieIII_6 + SerieIII_7 + SerieIII_8 + SerieIII_9 + SerieIII_10 + SerieIII_11 + SerieIII_12 + SerieIII_13 + SerieIII_14 + SerieIII_15" +
                                                                                 "   + SerieIII_16 + SerieIII_17 + SerieIII_18 + SerieIII_19 + SerieIII_20 + SerieIII_21 + SerieIII_22 + SerieIII_23 + SerieIII_24 + SerieIII_25 + SerieIII_26 + SerieIII_27 + SerieIII_28 + SerieIII_29" +
                                                                                 "   + SerieIII_30) " +
                                                                                 "  - (InSerieIII_1 + InSerieIII_2 + InSerieIII_3 + InSerieIII_4 + InSerieIII_5 + InSerieIII_6 + InSerieIII_7 + InSerieIII_8 + InSerieIII_9 + InSerieIII_10 + InSerieIII_11 + InSerieIII_12 + InSerieIII_13" +
                                                                                 "   + InSerieIII_14 + InSerieIII_15 + InSerieIII_16 + InSerieIII_17 + InSerieIII_18 + InSerieIII_19 + InSerieIII_20 + InSerieIII_21 + InSerieIII_22 + InSerieIII_23 + InSerieIII_24 + InSerieIII_25 + InSerieIII_26" +
                                                                                 "   + InSerieIII_27 + InSerieIII_28 + InSerieIII_29 + InSerieIII_30) AS Serie3, " +
                                                                                 "   SerieIV_1 +SerieIV_2 + SerieIV_3 + SerieIV_4 + SerieIV_5 + SerieIV_6 + SerieIV_7 + SerieIV_8 + SerieIV_9 + SerieIV_10 + SerieIV_11 + SerieIV_12 + SerieIV_13 + SerieIV_14 + SerieIV_15" +
                                                                                 "   + SerieIV_16 + SerieIV_17 + SerieIV_18 AS Serie4, " +
                                                                                 "  (SerieV_1 + SerieV_2 + SerieV_3 + SerieV_4 + SerieV_5 + SerieV_6 + SerieV_7 + SerieV_8 + SerieV_9 + SerieV_10 + SerieV_11 + SerieV_12) * 2 AS Serie5, " +
                                                                                 "  (SerieVI_1 + SerieVI_2 + SerieVI_3 + SerieVI_4 + SerieVI_5 + SerieVI_6 + SerieVI_7 + SerieVI_8 + SerieVI_9 + SerieVI_10 + SerieVI_11 + SerieVI_12 + SerieVI_13 + SerieVI_14 + SerieVI_15" +
                                                                                 "   + SerieVI_16 + SerieVI_17 + SerieVI_18 + SerieVI_19 + SerieVI_20) " +
                                                                                 "  - (InSerieVI_1 + InSerieVI_2 + InSerieVI_3 + InSerieVI_4 + InSerieVI_5 + InSerieVI_6 + InSerieVI_7 + InSerieVI_8 + InSerieVI_9 + InSerieVI_10 + InSerieVI_11 + InSerieVI_12 + InSerieVI_13" +
                                                                                 "   + InSerieVI_14 + InSerieVI_15 + InSerieVI_16 + InSerieVI_17 + InSerieVI_18 + InSerieVI_19 + InSerieVI_20) AS Serie6, " +
                                                                                 "   SerieVII_1+SerieVII_2 + SerieVII_3 + SerieVII_4 + SerieVII_5 + SerieVII_6 + SerieVII_7 + SerieVII_8 + SerieVII_9 + SerieVII_10 + SerieVII_11 + SerieVII_12 + SerieVII_13 + SerieVII_14 + SerieVII_15" +
                                                                                 "   + SerieVII_16 + SerieVII_17 + SerieVII_18 + SerieVII_19 + SerieVII_20 AS Serie7, " +
                                                                                 "  (SerieVIII_1 + SerieVIII_2 + SerieVIII_3 + SerieVIII_4 + SerieVIII_5 + SerieVIII_6 + SerieVIII_7 + SerieVIII_8 + SerieVIII_9 + SerieVIII_10 + SerieVIII_11 + SerieVIII_12 + SerieVIII_13 + SerieVIII_14" +
                                                                                 "   + SerieVIII_15 + SerieVIII_16 + SerieVIII_17) " +
                                                                                 "  - (InSerieVIII_1 + InSerieVIII_2 + InSerieVIII_3 + InSerieVIII_4 + InSerieVIII_5 + InSerieVIII_6 + InSerieVIII_7 + InSerieVIII_8 + InSerieVIII_9 + InSerieVIII_10 + InSerieVIII_11 + InSerieVIII_12 +" +
                                                                                 "   InSerieVIII_13 + InSerieVIII_14 + InSerieVIII_15 + InSerieVIII_16 + InSerieVIII_17) AS Serie8, " +
                                                                                 "   SerieIX_1+SerieIX_2 + SerieIX_3 + SerieIX_4 + SerieIX_5 + SerieIX_6 + SerieIX_7 + SerieIX_8 + SerieIX_9 + SerieIX_10 + SerieIX_11 + SerieIX_12 + SerieIX_13 + SerieIX_14 + SerieIX_15" +
                                                                                 "   + SerieIX_16 + SerieIX_17 + SerieIX_18 AS Serie9, (SerieX_1 + SerieX_2 + SerieX_3 + SerieX_4 + SerieX_5 + SerieX_6 + SerieX_7 + SerieX_8 + SerieX_9 + SerieX_10 + SerieX_11) " +
                                                                                 "  * 2 AS Serie10" +
                                                      "   FROM            (SELECT        id_candidato, tst_nombre, tst_fecha, tst_edad, tst_puesto,CI, (CASE WHEN sr1_resp1 = 'B' THEN 1 ELSE 0 END) AS SerieI_1, (CASE WHEN sr1_resp2 = 'A' THEN 1 ELSE 0 END)" +
                                                                                                            "  AS SerieI_2, (CASE WHEN sr1_resp3 = 'B' THEN 1 ELSE 0 END) AS SerieI_3, (CASE WHEN sr1_resp4 = 'A' THEN 1 ELSE 0 END) AS SerieI_4, " +
                                                                                                            " (CASE WHEN sr1_resp5 = 'B' THEN 1 ELSE 0 END) AS SerieI_5, (CASE WHEN sr1_resp6 = 'D' THEN 1 ELSE 0 END) AS SerieI_6, " +
                                                                                                            " (CASE WHEN sr1_resp7 = 'C' THEN 1 ELSE 0 END) AS SerieI_7, (CASE WHEN sr1_resp8 = 'A' THEN 1 ELSE 0 END) AS SerieI_8, " +
                                                                                                            " (CASE WHEN sr1_resp9 = 'C' THEN 1 ELSE 0 END) AS SerieI_9, (CASE WHEN sr1_resp10 = 'C' THEN 1 ELSE 0 END) AS SerieI_10, " +
                                                                                                            " (CASE WHEN sr1_resp11 = 'C' THEN 1 ELSE 0 END) AS SerieI_11, (CASE WHEN sr1_resp12 = 'B' THEN 1 ELSE 0 END) AS SerieI_12, " +
                                                                                                            " (CASE WHEN sr1_resp13 = 'B' THEN 1 ELSE 0 END) AS SerieI_13, (CASE WHEN sr1_resp14 = 'C' THEN 1 ELSE 0 END) AS SerieI_14, " +
                                                                                                            " (CASE WHEN sr1_resp15 = 'A' THEN 1 ELSE 0 END) AS SerieI_15, (CASE WHEN sr1_resp16 = 'C' THEN 1 ELSE 0 END) AS SerieI_16, " +
                                                                                                            " (CASE WHEN sr2_resp1 = 'C' THEN 1 ELSE 0 END) AS SerieII_1, (CASE WHEN sr2_resp2 = 'A' THEN 1 ELSE 0 END) AS SerieII_2, " +
                                                                                                            " (CASE WHEN sr2_resp3 = 'B' THEN 1 ELSE 0 END) AS SerieII_3, (CASE WHEN sr2_resp4 = 'C' THEN 1 ELSE 0 END) AS SerieII_4, " +
                                                                                                            " (CASE WHEN sr2_resp5 = 'C' THEN 1 ELSE 0 END) AS SerieII_5, (CASE WHEN sr2_resp6 = 'B' THEN 1 ELSE 0 END) AS SerieII_6, " +
                                                                                                            " (CASE WHEN sr2_resp7 = 'C' THEN 1 ELSE 0 END) AS SerieII_7, (CASE WHEN sr2_resp8 = 'C' THEN 1 ELSE 0 END) AS SerieII_8, " +
                                                                                                            " (CASE WHEN sr2_resp9 = 'B' THEN 1 ELSE 0 END) AS SerieII_9, (CASE WHEN sr2_resp10 = 'A' THEN 1 ELSE 0 END) AS SerieII_10, " +
                                                                                                            " (CASE WHEN sr2_resp11 = 'B' THEN 1 ELSE 0 END) AS SerieII_11, (CASE WHEN sr3_resp1 = 'O' THEN 1 ELSE 0 END) AS SerieIII_1, " +
                                                                                                            " (CASE WHEN sr3_resp2 = 'I' THEN 1 ELSE 0 END) AS SerieIII_2, (CASE WHEN sr3_resp3 = 'O' THEN 1 ELSE 0 END) AS SerieIII_3, " +
                                                                                                            " (CASE WHEN sr3_resp4 = 'O' THEN 1 ELSE 0 END) AS SerieIII_4, (CASE WHEN sr3_resp5 = 'O' THEN 1 ELSE 0 END) AS SerieIII_5, " +
                                                                                                            " (CASE WHEN sr3_resp6 = 'O' THEN 1 ELSE 0 END) AS SerieIII_6, (CASE WHEN sr3_resp7 = 'I' THEN 1 ELSE 0 END) AS SerieIII_7, " +
                                                                                                            " (CASE WHEN sr3_resp8 = 'I' THEN 1 ELSE 0 END) AS SerieIII_8, (CASE WHEN sr3_resp9 = 'O' THEN 1 ELSE 0 END) AS SerieIII_9, " +
                                                                                                            " (CASE WHEN sr3_resp10 = 'I' THEN 1 ELSE 0 END) AS SerieIII_10, (CASE WHEN sr3_resp11 = 'O' THEN 1 ELSE 0 END) AS SerieIII_11, " +
                                                                                                            " (CASE WHEN sr3_resp12 = 'O' THEN 1 ELSE 0 END) AS SerieIII_12, (CASE WHEN sr3_resp13 = 'O' THEN 1 ELSE 0 END) AS SerieIII_13, " +
                                                                                                            " (CASE WHEN sr3_resp14 = 'I' THEN 1 ELSE 0 END) AS SerieIII_14, (CASE WHEN sr3_resp15 = 'O' THEN 1 ELSE 0 END) AS SerieIII_15, " +
                                                                                                            " (CASE WHEN sr3_resp16 = 'O' THEN 1 ELSE 0 END) AS SerieIII_16, (CASE WHEN sr3_resp17 = 'I' THEN 1 ELSE 0 END) AS SerieIII_17, " +
                                                                                                            " (CASE WHEN sr3_resp18 = 'O' THEN 1 ELSE 0 END) AS SerieIII_18, (CASE WHEN sr3_resp19 = 'I' THEN 1 ELSE 0 END) AS SerieIII_19, " +
                                                                                                            " (CASE WHEN sr3_resp20 = 'O' THEN 1 ELSE 0 END) AS SerieIII_20, (CASE WHEN sr3_resp21 = 'O' THEN 1 ELSE 0 END) AS SerieIII_21, " +
                                                                                                            " (CASE WHEN sr3_resp22 = 'O' THEN 1 ELSE 0 END) AS SerieIII_22, (CASE WHEN sr3_resp23 = 'I' THEN 1 ELSE 0 END) AS SerieIII_23, " +
                                                                                                            " (CASE WHEN sr3_resp24 = 'I' THEN 1 ELSE 0 END) AS SerieIII_24, (CASE WHEN sr3_resp25 = 'I' THEN 1 ELSE 0 END) AS SerieIII_25, " +
                                                                                                            " (CASE WHEN sr3_resp26 = 'O' THEN 1 ELSE 0 END) AS SerieIII_26, (CASE WHEN sr3_resp27 = 'I' THEN 1 ELSE 0 END) AS SerieIII_27, " +
                                                                                                            " (CASE WHEN sr3_resp28 = 'I' THEN 1 ELSE 0 END) AS SerieIII_28, (CASE WHEN sr3_resp29 = 'O' THEN 1 ELSE 0 END) AS SerieIII_29, " +
                                                                                                            " (CASE WHEN sr3_resp30 = 'I' THEN 1 ELSE 0 END) AS SerieIII_30, (CASE WHEN sr3_resp1 <> 'O' THEN 1 ELSE 0 END) AS InSerieIII_1, " +
                                                                                                            " (CASE WHEN sr3_resp2 <> 'I' THEN 1 ELSE 0 END) AS InSerieIII_2, (CASE WHEN sr3_resp3 <> 'O' THEN 1 ELSE 0 END) AS InSerieIII_3, " +
                                                                                                            " (CASE WHEN sr3_resp4 <> 'O' THEN 1 ELSE 0 END) AS InSerieIII_4, (CASE WHEN sr3_resp5 <> 'O' THEN 1 ELSE 0 END) AS InSerieIII_5, " +
                                                                                                            " (CASE WHEN sr3_resp6 <> 'O' THEN 1 ELSE 0 END) AS InSerieIII_6, (CASE WHEN sr3_resp7 <> 'I' THEN 1 ELSE 0 END) AS InSerieIII_7, " +
                                                                                                            " (CASE WHEN sr3_resp8 <> 'I' THEN 1 ELSE 0 END) AS InSerieIII_8, (CASE WHEN sr3_resp9 <> 'O' THEN 1 ELSE 0 END) AS InSerieIII_9, " +
                                                                                                            " (CASE WHEN sr3_resp10 <> 'I' THEN 1 ELSE 0 END) AS InSerieIII_10, (CASE WHEN sr3_resp11 <> 'O' THEN 1 ELSE 0 END) AS InSerieIII_11, " +
                                                                                                            " (CASE WHEN sr3_resp12 <> 'O' THEN 1 ELSE 0 END) AS InSerieIII_12, (CASE WHEN sr3_resp13 <> 'O' THEN 1 ELSE 0 END) AS InSerieIII_13, " +
                                                                                                            " (CASE WHEN sr3_resp14 <> 'I' THEN 1 ELSE 0 END) AS InSerieIII_14, (CASE WHEN sr3_resp15 <> 'O' THEN 1 ELSE 0 END) AS InSerieIII_15, " +
                                                                                                            " (CASE WHEN sr3_resp16 <> 'O' THEN 1 ELSE 0 END) AS InSerieIII_16, (CASE WHEN sr3_resp17 <> 'I' THEN 1 ELSE 0 END) AS InSerieIII_17, " +
                                                                                                            " (CASE WHEN sr3_resp18 <> 'O' THEN 1 ELSE 0 END) AS InSerieIII_18, (CASE WHEN sr3_resp19 <> 'I' THEN 1 ELSE 0 END) AS InSerieIII_19, " +
                                                                                                            " (CASE WHEN sr3_resp20 <> 'O' THEN 1 ELSE 0 END) AS InSerieIII_20, (CASE WHEN sr3_resp21 <> 'O' THEN 1 ELSE 0 END) AS InSerieIII_21, " +
                                                                                                            " (CASE WHEN sr3_resp22 <> 'O' THEN 1 ELSE 0 END) AS InSerieIII_22, (CASE WHEN sr3_resp23 <> 'I' THEN 1 ELSE 0 END) AS InSerieIII_23, " +
                                                                                                            " (CASE WHEN sr3_resp24 <> 'I' THEN 1 ELSE 0 END) AS InSerieIII_24, (CASE WHEN sr3_resp25 <> 'I' THEN 1 ELSE 0 END) AS InSerieIII_25, " +
                                                                                                            " (CASE WHEN sr3_resp26 <> 'O' THEN 1 ELSE 0 END) AS InSerieIII_26, (CASE WHEN sr3_resp27 <> 'I' THEN 1 ELSE 0 END) AS InSerieIII_27, " +
                                                                                                            " (CASE WHEN sr3_resp28 <> 'I' THEN 1 ELSE 0 END) AS InSerieIII_28, (CASE WHEN sr3_resp29 <> 'O' THEN 1 ELSE 0 END) AS InSerieIII_29, " +
                                                                                                            " (CASE WHEN sr3_resp30 <> 'I' THEN 1 ELSE 0 END) AS InSerieIII_30, (CASE WHEN sr4_resp1 = 'B;E' THEN 1 ELSE 0 END) AS SerieIV_1, " +
                                                                                                            " (CASE WHEN sr4_resp2 = 'A;C' THEN 1 ELSE 0 END) AS SerieIV_2, (CASE WHEN sr4_resp3 = 'C;D' THEN 1 ELSE 0 END) AS SerieIV_3, " +
                                                                                                            " (CASE WHEN sr4_resp4 = 'A;C' THEN 1 ELSE 0 END) AS SerieIV_4, (CASE WHEN sr4_resp5 = 'B;E' THEN 1 ELSE 0 END) AS SerieIV_5, " +
                                                                                                            " (CASE WHEN sr4_resp6 = 'C;E' THEN 1 ELSE 0 END) AS SerieIV_6, (CASE WHEN sr4_resp7 = 'B;E' THEN 1 ELSE 0 END) AS SerieIV_7, " +
                                                                                                            " (CASE WHEN sr4_resp8 = 'B;E' THEN 1 ELSE 0 END) AS SerieIV_8, (CASE WHEN sr4_resp9 = 'A;B' THEN 1 ELSE 0 END) AS SerieIV_9, " +
                                                                                                            " (CASE WHEN sr4_resp10 = 'A;C' THEN 1 ELSE 0 END) AS SerieIV_10, (CASE WHEN sr4_resp11 = 'B;C' THEN 1 ELSE 0 END) AS SerieIV_11, " +
                                                                                                            " (CASE WHEN sr4_resp12 = 'A;B' THEN 1 ELSE 0 END) AS SerieIV_12, (CASE WHEN sr4_resp13 = 'C;E' THEN 1 ELSE 0 END) AS SerieIV_13, " +
                                                                                                            " (CASE WHEN sr4_resp14 = 'A;D' THEN 1 ELSE 0 END) AS SerieIV_14, (CASE WHEN sr4_resp15 = 'A;B' THEN 1 ELSE 0 END) AS SerieIV_15, " +
                                                                                                            " (CASE WHEN sr4_resp16 = 'B;E' THEN 1 ELSE 0 END) AS SerieIV_16, (CASE WHEN sr4_resp17 = 'A;B' THEN 1 ELSE 0 END) AS SerieIV_17, " +
                                                                                                            " (CASE WHEN sr4_resp18 = 'C;D' THEN 1 ELSE 0 END) AS SerieIV_18, (CASE WHEN sr5_resp1 = '20' THEN 1 ELSE 0 END) AS SerieV_1, " +
                                                                                                            " (CASE WHEN sr5_resp2 = '11' THEN 1 ELSE 0 END) AS SerieV_2, (CASE WHEN sr5_resp3 = '50' THEN 1 ELSE 0 END) AS SerieV_3, " +
                                                                                                            " (CASE WHEN sr5_resp4 = '50' THEN 1 ELSE 0 END) AS SerieV_4, (CASE WHEN sr5_resp5 = '12' THEN 1 ELSE 0 END) AS SerieV_5, " +
                                                                                                            " (CASE WHEN sr5_resp6 = '18' THEN 1 ELSE 0 END) AS SerieV_6, (CASE WHEN sr5_resp7 = '500' THEN 1 ELSE 0 END) AS SerieV_7, " +
                                                                                                            " (CASE WHEN sr5_resp8 = '2' THEN 1 ELSE 0 END) AS SerieV_8, (CASE WHEN sr5_resp9 = '28' THEN 1 ELSE 0 END) AS SerieV_9, " +
                                                                                                            " (CASE WHEN sr5_resp10 = '360' THEN 1 ELSE 0 END) AS SerieV_10, (CASE WHEN sr5_resp11 = '2' THEN 1 ELSE 0 END) AS SerieV_11, " +
                                                                                                            " (CASE WHEN sr5_resp12 = '25' THEN 1 ELSE 0 END) AS SerieV_12, (CASE WHEN sr6_resp1 = 'SI' THEN 1 ELSE 0 END) AS SerieVI_1, " +
                                                                                                            " (CASE WHEN sr6_resp2 = 'NO' THEN 1 ELSE 0 END) AS SerieVI_2, (CASE WHEN sr6_resp3 = 'NO' THEN 1 ELSE 0 END) AS SerieVI_3, " +
                                                                                                            " (CASE WHEN sr6_resp4 = 'SI' THEN 1 ELSE 0 END) AS SerieVI_4, (CASE WHEN sr6_resp5 = 'SI' THEN 1 ELSE 0 END) AS SerieVI_5, " +
                                                                                                            " (CASE WHEN sr6_resp6 = 'NO' THEN 1 ELSE 0 END) AS SerieVI_6, (CASE WHEN sr6_resp7 = 'NO' THEN 1 ELSE 0 END) AS SerieVI_7, " +
                                                                                                            " (CASE WHEN sr6_resp8 = 'NO' THEN 1 ELSE 0 END) AS SerieVI_8, (CASE WHEN sr6_resp9 = 'SI' THEN 1 ELSE 0 END) AS SerieVI_9, " +
                                                                                                            " (CASE WHEN sr6_resp10 = 'SI' THEN 1 ELSE 0 END) AS SerieVI_10, (CASE WHEN sr6_resp11 = 'NO' THEN 1 ELSE 0 END) AS SerieVI_11, " +
                                                                                                            " (CASE WHEN sr6_resp12 = 'NO' THEN 1 ELSE 0 END) AS SerieVI_12, (CASE WHEN sr6_resp13 = 'NO' THEN 1 ELSE 0 END) AS SerieVI_13, " +
                                                                                                            " (CASE WHEN sr6_resp14 = 'SI' THEN 1 ELSE 0 END) AS SerieVI_14, (CASE WHEN sr6_resp15 = 'NO' THEN 1 ELSE 0 END) AS SerieVI_15, " +
                                                                                                            " (CASE WHEN sr6_resp16 = 'NO' THEN 1 ELSE 0 END) AS SerieVI_16, (CASE WHEN sr6_resp17 = 'SI' THEN 1 ELSE 0 END) AS SerieVI_17, " +
                                                                                                            " (CASE WHEN sr6_resp18 = 'NO' THEN 1 ELSE 0 END) AS SerieVI_18, (CASE WHEN sr6_resp19 = 'NO' THEN 1 ELSE 0 END) AS SerieVI_19, " +
                                                                                                            " (CASE WHEN sr6_resp20 = 'SI' THEN 1 ELSE 0 END) AS SerieVI_20, (CASE WHEN sr6_resp1 <> 'SI' THEN 1 ELSE 0 END) AS InSerieVI_1, " +
                                                                                                            " (CASE WHEN sr6_resp2 <> 'NO' THEN 1 ELSE 0 END) AS InSerieVI_2, (CASE WHEN sr6_resp3 <> 'NO' THEN 1 ELSE 0 END) AS InSerieVI_3, " +
                                                                                                            " (CASE WHEN sr6_resp4 <> 'SI' THEN 1 ELSE 0 END) AS InSerieVI_4, (CASE WHEN sr6_resp5 <> 'SI' THEN 1 ELSE 0 END) AS InSerieVI_5, " +
                                                                                                            " (CASE WHEN sr6_resp6 <> 'NO' THEN 1 ELSE 0 END) AS InSerieVI_6, (CASE WHEN sr6_resp7 <> 'NO' THEN 1 ELSE 0 END) AS InSerieVI_7, " +
                                                                                                            " (CASE WHEN sr6_resp8 <> 'NO' THEN 1 ELSE 0 END) AS InSerieVI_8, (CASE WHEN sr6_resp9 <> 'SI' THEN 1 ELSE 0 END) AS InSerieVI_9, " +
                                                                                                            " (CASE WHEN sr6_resp10 <> 'SI' THEN 1 ELSE 0 END) AS InSerieVI_10, (CASE WHEN sr6_resp11 <> 'NO' THEN 1 ELSE 0 END) AS InSerieVI_11, " +
                                                                                                            " (CASE WHEN sr6_resp12 <> 'NO' THEN 1 ELSE 0 END) AS InSerieVI_12, (CASE WHEN sr6_resp13 <> 'NO' THEN 1 ELSE 0 END) AS InSerieVI_13, " +
                                                                                                            " (CASE WHEN sr6_resp14 <> 'SI' THEN 1 ELSE 0 END) AS InSerieVI_14, (CASE WHEN sr6_resp15 <> 'NO' THEN 1 ELSE 0 END) AS InSerieVI_15, " +
                                                                                                            " (CASE WHEN sr6_resp16 <> 'NO' THEN 1 ELSE 0 END) AS InSerieVI_16, (CASE WHEN sr6_resp17 <> 'SI' THEN 1 ELSE 0 END) AS InSerieVI_17, " +
                                                                                                            " (CASE WHEN sr6_resp18 <> 'NO' THEN 1 ELSE 0 END) AS InSerieVI_18, (CASE WHEN sr6_resp19 <> 'NO' THEN 1 ELSE 0 END) AS InSerieVI_19, " +
                                                                                                            " (CASE WHEN sr6_resp20 <> 'SI' THEN 1 ELSE 0 END) AS InSerieVI_20, (CASE WHEN sr7_resp1 = 'A' THEN 1 ELSE 0 END) AS SerieVII_1, " +
                                                                                                            " (CASE WHEN sr7_resp2 = 'A' THEN 1 ELSE 0 END) AS SerieVII_2, (CASE WHEN sr7_resp3 = 'C' THEN 1 ELSE 0 END) AS SerieVII_3, " +
                                                                                                            " (CASE WHEN sr7_resp4 = 'B' THEN 1 ELSE 0 END) AS SerieVII_4, (CASE WHEN sr7_resp5 = 'B' THEN 1 ELSE 0 END) AS SerieVII_5, " +
                                                                                                            " (CASE WHEN sr7_resp6 = 'D' THEN 1 ELSE 0 END) AS SerieVII_6, (CASE WHEN sr7_resp7 = 'C' THEN 1 ELSE 0 END) AS SerieVII_7, " +
                                                                                                            " (CASE WHEN sr7_resp8 = 'A' THEN 1 ELSE 0 END) AS SerieVII_8, (CASE WHEN sr7_resp9 = 'A' THEN 1 ELSE 0 END) AS SerieVII_9, " +
                                                                                                            " (CASE WHEN sr7_resp10 = 'D' THEN 1 ELSE 0 END) AS SerieVII_10, (CASE WHEN sr7_resp11 = 'B' THEN 1 ELSE 0 END) AS SerieVII_11, " +
                                                                                                            " (CASE WHEN sr7_resp12 = 'C' THEN 1 ELSE 0 END) AS SerieVII_12, (CASE WHEN sr7_resp13 = 'B' THEN 1 ELSE 0 END) AS SerieVII_13, " +
                                                                                                            " (CASE WHEN sr7_resp14 = 'C' THEN 1 ELSE 0 END) AS SerieVII_14, (CASE WHEN sr7_resp15 = 'C' THEN 1 ELSE 0 END) AS SerieVII_15, " +
                                                                                                            " (CASE WHEN sr7_resp16 = 'C' THEN 1 ELSE 0 END) AS SerieVII_16, (CASE WHEN sr7_resp17 = 'B' THEN 1 ELSE 0 END) AS SerieVII_17, " +
                                                                                                            " (CASE WHEN sr7_resp18 = 'C' THEN 1 ELSE 0 END) AS SerieVII_18, (CASE WHEN sr7_resp19 = 'C' THEN 1 ELSE 0 END) AS SerieVII_19, " +
                                                                                                            " (CASE WHEN sr7_resp20 = 'C' THEN 1 ELSE 0 END) AS SerieVII_20, (CASE WHEN sr8_resp1 = 'V' THEN 1 ELSE 0 END) AS SerieVIII_1, " +
                                                                                                            " (CASE WHEN sr8_resp2 = 'F' THEN 1 ELSE 0 END) AS SerieVIII_2, (CASE WHEN sr8_resp3 = 'V' THEN 1 ELSE 0 END) AS SerieVIII_3, " +
                                                                                                            " (CASE WHEN sr8_resp4 = 'V' THEN 1 ELSE 0 END) AS SerieVIII_4, (CASE WHEN sr8_resp5 = 'V' THEN 1 ELSE 0 END) AS SerieVIII_5, " +
                                                                                                            " (CASE WHEN sr8_resp6 = 'F' THEN 1 ELSE 0 END) AS SerieVIII_6, (CASE WHEN sr8_resp7 = 'F' THEN 1 ELSE 0 END) AS SerieVIII_7, " +
                                                                                                            " (CASE WHEN sr8_resp8 = 'V' THEN 1 ELSE 0 END) AS SerieVIII_8, (CASE WHEN sr8_resp9 = 'V' THEN 1 ELSE 0 END) AS SerieVIII_9, " +
                                                                                                            " (CASE WHEN sr8_resp10 = 'F' THEN 1 ELSE 0 END) AS SerieVIII_10, (CASE WHEN sr8_resp11 = 'F' THEN 1 ELSE 0 END) AS SerieVIII_11, " +
                                                                                                            " (CASE WHEN sr8_resp12 = 'F' THEN 1 ELSE 0 END) AS SerieVIII_12, (CASE WHEN sr8_resp13 = 'V' THEN 1 ELSE 0 END) AS SerieVIII_13, " +
                                                                                                            " (CASE WHEN sr8_resp14 = 'V' THEN 1 ELSE 0 END) AS SerieVIII_14, (CASE WHEN sr8_resp15 = 'V' THEN 1 ELSE 0 END) AS SerieVIII_15, " +
                                                                                                            " (CASE WHEN sr8_resp16 = 'V' THEN 1 ELSE 0 END) AS SerieVIII_16, (CASE WHEN sr8_resp17 = 'F' THEN 1 ELSE 0 END) AS SerieVIII_17, " +
                                                                                                            " (CASE WHEN sr8_resp1 <> 'V' THEN 1 ELSE 0 END) AS InSerieVIII_1, (CASE WHEN sr8_resp2 <> 'F' THEN 1 ELSE 0 END) AS InSerieVIII_2, " +
                                                                                                            " (CASE WHEN sr8_resp3 <> 'V' THEN 1 ELSE 0 END) AS InSerieVIII_3, (CASE WHEN sr8_resp4 <> 'V' THEN 1 ELSE 0 END) AS InSerieVIII_4, " +
                                                                                                            " (CASE WHEN sr8_resp5 <> 'V' THEN 1 ELSE 0 END) AS InSerieVIII_5, (CASE WHEN sr8_resp6 <> 'F' THEN 1 ELSE 0 END) AS InSerieVIII_6, " +
                                                                                                            " (CASE WHEN sr8_resp7 <> 'F' THEN 1 ELSE 0 END) AS InSerieVIII_7, (CASE WHEN sr8_resp8 <> 'V' THEN 1 ELSE 0 END) AS InSerieVIII_8, " +
                                                                                                            " (CASE WHEN sr8_resp9 <> 'V' THEN 1 ELSE 0 END) AS InSerieVIII_9, (CASE WHEN sr8_resp10 <> 'F' THEN 1 ELSE 0 END) AS InSerieVIII_10, " +
                                                                                                            " (CASE WHEN sr8_resp11 <> 'F' THEN 1 ELSE 0 END) AS InSerieVIII_11, (CASE WHEN sr8_resp12 <> 'F' THEN 1 ELSE 0 END) AS InSerieVIII_12, " +
                                                                                                            " (CASE WHEN sr8_resp13 <> 'V' THEN 1 ELSE 0 END) AS InSerieVIII_13, (CASE WHEN sr8_resp14 <> 'V' THEN 1 ELSE 0 END) AS InSerieVIII_14, " +
                                                                                                            " (CASE WHEN sr8_resp15 <> 'V' THEN 1 ELSE 0 END) AS InSerieVIII_15, (CASE WHEN sr8_resp16 <> 'V' THEN 1 ELSE 0 END) AS InSerieVIII_16, " +
                                                                                                            " (CASE WHEN sr8_resp17 <> 'F' THEN 1 ELSE 0 END) AS InSerieVIII_17, (CASE WHEN sr9_resp1 = 'D' THEN 1 ELSE 0 END) AS SerieIX_1, " +
                                                                                                            " (CASE WHEN sr9_resp2 = 'E' THEN 1 ELSE 0 END) AS SerieIX_2, (CASE WHEN sr9_resp3 = 'C' THEN 1 ELSE 0 END) AS SerieIX_3, " +
                                                                                                            " (CASE WHEN sr9_resp4 = 'A' THEN 1 ELSE 0 END) AS SerieIX_4, (CASE WHEN sr9_resp5 = 'C' THEN 1 ELSE 0 END) AS SerieIX_5, " +
                                                                                                            " (CASE WHEN sr9_resp6 = 'D' THEN 1 ELSE 0 END) AS SerieIX_6, (CASE WHEN sr9_resp7 = 'E' THEN 1 ELSE 0 END) AS SerieIX_7, " +
                                                                                                            " (CASE WHEN sr9_resp8 = 'A' THEN 1 ELSE 0 END) AS SerieIX_8, (CASE WHEN sr9_resp9 = 'D' THEN 1 ELSE 0 END) AS SerieIX_9, " +
                                                                                                            " (CASE WHEN sr9_resp10 = 'C' THEN 1 ELSE 0 END) AS SerieIX_10, (CASE WHEN sr9_resp11 = 'E' THEN 1 ELSE 0 END) AS SerieIX_11, " +
                                                                                                            " (CASE WHEN sr9_resp12 = 'E' THEN 1 ELSE 0 END) AS SerieIX_12, (CASE WHEN sr9_resp13 = 'A' THEN 1 ELSE 0 END) AS SerieIX_13, " +
                                                                                                            " (CASE WHEN sr9_resp14 = 'E' THEN 1 ELSE 0 END) AS SerieIX_14, (CASE WHEN sr9_resp15 = 'E' THEN 1 ELSE 0 END) AS SerieIX_15, " +
                                                                                                            " (CASE WHEN sr9_resp16 = 'A' THEN 1 ELSE 0 END) AS SerieIX_16, (CASE WHEN sr9_resp17 = 'D' THEN 1 ELSE 0 END) AS SerieIX_17, " +
                                                                                                            " (CASE WHEN sr9_resp18 = 'E' THEN 1 ELSE 0 END) AS SerieIX_18, (CASE WHEN sr10_resp1 = '21' THEN 1 ELSE 0 END) AS SerieX_1, " +
                                                                                                            " (CASE WHEN sr10_resp2 = '3338' THEN 1 ELSE 0 END) AS SerieX_2, (CASE WHEN sr10_resp3 = '64128' THEN 1 ELSE 0 END) AS SerieX_3, " +
                                                                                                            " (CASE WHEN sr10_resp4 = '22' THEN 1 ELSE 0 END) AS SerieX_4, (CASE WHEN sr10_resp5 = '13131/4' OR" +
                                                                                                            " sr10_resp5 = '1313.25' THEN 1 ELSE 0 END) AS SerieX_5, (CASE WHEN sr10_resp6 = '2021' THEN 1 ELSE 0 END) AS SerieX_6, (CASE WHEN sr10_resp7 = '1/41/8' OR" +
                                                                                                            " sr10_resp7 = '0.250.125' THEN 1 ELSE 0 END) AS SerieX_7, (CASE WHEN sr10_resp8 = '85.394.3' THEN 1 ELSE 0 END) AS SerieX_8, " +
                                                                                                            " (CASE WHEN sr10_resp9 = '68' THEN 1 ELSE 0 END) AS SerieX_9, (CASE WHEN sr10_resp10 = '3334' THEN 1 ELSE 0 END) AS SerieX_10, " +
                                                                                                            " (CASE WHEN sr10_resp11 = '25125' THEN 1 ELSE 0 END) AS SerieX_11" +
           " FROM rh_test_merril  WHERE (id_candidato <> 0)) AS tot) AS rang where id_candidato=" & id & ""
            Dim comando As SqlCommand
            Dim lector As SqlDataReader

            comando = New SqlCommand(query, conexiones)
            lector = comando.ExecuteReader
            If lector.Read Then
                r1 = lector(0).ToString
                r2 = lector(1).ToString
                r3 = lector(2).ToString
                r4 = lector(3).ToString
                r5 = lector(4).ToString
                r6 = lector(5).ToString
                r7 = lector(6).ToString
                r8 = lector(7).ToString
                r9 = lector(8).ToString
                r10 = lector(9).ToString
                rg = lector(10).ToString
            End If
            lector.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al insertar Rangos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            Dim comando2 As SqlCommand

            abrir()
            ' MsgBox(r1 & "," & r2 & "," & r3 & "," & r4 & "," & r5 & "," & r6 & "," & r7 & "," & r8 & "," & r9 & "," & r10 & "," & rg)
            comando2 = New SqlCommand("update rh_test_merril set Rango1='" & r1 & "', Rango2='" & r2 & "',Rango3='" & r3 & "',Rango4='" & r4 & "',Rango5='" & r5 & "',Rango6='" & r6 & "',Rango7='" & r7 & "',Rango8='" & r8 & "',Rango9='" & r9 & "',Rango10='" & r10 & "',RangoG='" & rg & "' where id_candidato=" & id & "", conexiones)
            comando2.ExecuteNonQuery()
            conexiones.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al insertar Rangos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexiones.Close()
        End Try
        Return Nothing
    End Function

    Function autentificar(ByVal nombre As String)
        Dim contraseña As String
        Try
            abrir()
            Dim query As String = "select pswd1 from sec_users where login='" & nombre & "'"
            Dim comando As SqlCommand
            Dim lector As SqlDataReader
            comando = New SqlCommand(query, conexiones)
            lector = comando.ExecuteReader
            If lector.Read Then
                contraseña = lector(0).ToString
                menuMainST.noUser = False
            Else
                MessageBox.Show("Nombre de usuario no válido,verifique su información", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                menuMainST.noUser = True
                menuMainST.TextBox1.Text = ""
                menuMainST.TextBox1.Focus()
            End If
            lector.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al obtener información", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return contraseña
    End Function

End Module
