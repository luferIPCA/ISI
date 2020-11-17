<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
  <html>
  <table class="header">
	<tr>
        <th>Escolha o tipo de filme:</th>
            </tr> 
             <tr>
                 <th class="links" align="left">
                  <a href="AdultMovie.html">Filmes Adultos</a>
                  </th>
                  </tr>
                  <tr>
                        <th class="links" align="left">
                            <a href="PGMovie.html">Filmes PG</a>
                        </th>
                   </tr>
                  <tr>
                        <th class="links" align="left">
                            <a href="OutrosMovie.html">Outros Filmes</a>
                        </th>
                   </tr>
              
                    
  
  </table>
  <body>
  <h2>Filmes</h2>
  <table border="1">
    <tr bgcolor="#9acd32">
      <th>Título</th>
      <th>Diretor</th>
	  <th>Data de Lançamento</th>
	  <th>Rating</th>
	  <th>Duração</th>
	  <th>Categoria</th>
	  <th>Descrição</th>
	  
    </tr>
    <xsl:for-each select="Rows/Row">
    <tr>
      <td><xsl:value-of select="title"/></td>
      <td><xsl:value-of select="director"/></td>
	  <td><xsl:value-of select="release_year"/></td>
	  <td><xsl:value-of select="rating"/></td>
	  <td><xsl:value-of select="duration"/></td>
	  <td><xsl:value-of select="listed_in"/></td>
	  <td><xsl:value-of select="description"/></td>
    </tr>
    </xsl:for-each>
  </table>
  </body>
  </html>
</xsl:template>
</xsl:stylesheet> 